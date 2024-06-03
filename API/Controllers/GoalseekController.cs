using Application;
using Microsoft.AspNetCore.Mvc;
using TridentGoalSeek;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoalseekController : ControllerBase, IGoalSeekAlgorithm
    {
        private int multiplier;

        public GoalseekController() { }

        [HttpPost]
        public async Task<ActionResult> Galseek([FromForm] GoalSeekRequest request)
        {
            if (request.Multiplier < 0 || request.Input < 0 || request.MaximumIterations < 0 || request.RequiredOutput < 0)
            {
                throw new InvalidOperationException("Invalid data input");
            }

            var cal =  GoalseekFunction(request.Multiplier);
            var goalSeeker = new GoalSeek(cal);

            GoalSeekOptions options = new GoalSeekOptions(100m, 90m, 5, 0m, 1m, request.MaximumIterations, true);

            var seekResult = goalSeeker.SeekResult(request.RequiredOutput, options);
            
            var res = Calculate((decimal)seekResult.InputVariable);
            
            return Ok(res);
        }

        [NonAction]
        private IGoalSeekAlgorithm GoalseekFunction(int multiplier)
        {
             this.multiplier = multiplier;
             return this;
        }

        [NonAction]
        public decimal Calculate(decimal inputVariable)
        {
            return inputVariable * multiplier;
        }
    }
}