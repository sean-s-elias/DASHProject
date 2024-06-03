using API.Controllers;
using Application;


namespace GoalSeek.Test.Controllers
{
    public class GoalseekControllerTests
    {
        private GoalseekController _goalseekController;

        public GoalseekControllerTests()
        {
            _goalseekController = new GoalseekController();
        }

        [Fact]
        public void Calculate_GoalSeek_ReturnsNotNull()
        {
            //Arrange
            var GoalSeekData = new GoalSeekRequest
            {
                Multiplier = 3,
                Input = 9,
                MaximumIterations = 10,
                RequiredOutput = 50,
            };

            //Act
            var goalSeek = _goalseekController.Galseek(GoalSeekData);

            //Assert
            Assert.NotNull(goalSeek);
        }

        [Fact]
        public async void Calculate_GoalSeek_ThrowsInvalidException()
        {
            //Arrange
            var GoalSeekData = new GoalSeekRequest
            {
                Multiplier = -1,
                Input = 9,
                MaximumIterations = 10,
                RequiredOutput = 50,
            };

            //Act
            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => _goalseekController.Galseek(GoalSeekData));

            //Assert
            Assert.Equal("Invalid data input", ex.Message);
        }
    }
}