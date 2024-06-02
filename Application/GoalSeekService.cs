using TridentGoalSeek;

namespace Application
{
    public class GoalSeekService : IGoalSeekAlgorithm, IGoalSeekService
    {
        //Initially I used this a service layer to handle the logic 
        //but since I am using this 3rd party library TridentGoalSeek https://www.nuget.org/packages/TridentGoalSeek/1.0.5#readme-body-tab
        //The Calculate function only takes inputVariable and based on the documentation multiplier is required in the calculate function
        //obviously I can pass it from the controller however in the calculate function will be input * 0
        //I kept this as part of demo

        public decimal Calculate(decimal inputVariable)
        {
            throw new NotImplementedException();
        }

        public void CalculateGoalSeek(int multiplier)
        {
            throw new NotImplementedException();
        }
    }
}