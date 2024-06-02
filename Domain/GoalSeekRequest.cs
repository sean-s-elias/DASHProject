namespace Application
{
    public class GoalSeekRequest
    {
        public int Multiplier { get; set; }
        public decimal Input { get; set; }
        public int MaximumIterations { get; set; }
        public int RequiredOutput { get; set; }
    }
}