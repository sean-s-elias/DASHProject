using Application;
using Microsoft.AspNetCore.Mvc;
using TridentGoalSeek;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoalseekController : ControllerBase, IGoalSeekAlgorithm
    {
        private readonly IGoalSeekAlgorithm _goalSeekAlgorithm;
        private readonly IGoalSeekService _goalSeekService;

        private int multiplier;

        public GoalseekController(IGoalSeekAlgorithm goalSeekAlgorithm, IGoalSeekService goalSeekService)
        {
            _goalSeekAlgorithm = goalSeekAlgorithm;
            _goalSeekService = goalSeekService;
        }

        [HttpPost]
        public async Task<ActionResult> Galseek([FromForm] GoalSeekRequest request)
        {
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