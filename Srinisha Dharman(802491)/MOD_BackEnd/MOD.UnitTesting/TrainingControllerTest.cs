using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Mod.TrainingService.Models;
using Mod.TrainingService.Repository;
using Mod.TrainingService.Controllers;
namespace MOD.UnitTesting
{
    public class TrainingControllerTest
    {
        private readonly Mock<ITrainingRepository> _repo;
        private readonly TrainingController _controller;
        public TrainingControllerTest()
        {
            _repo = new Mock<ITrainingRepository>();
            _controller = new TrainingController(_repo.Object);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetTraining());
            var result = _controller.Get() as List<Training>;
            Assert.Equal(3, result.Count);

        }
        [Fact]
        public void GetById()
        {
            _repo.Setup(m => m.GetById(1)).Returns(GetTraining()[0]);
            var result = _controller.Get(1) as Training;
            Assert.NotNull(result);
            Assert.Equal(1, result.TrainingId);
        }
        private List<Training> GetTraining()
        {
            return new List<Training>()
            {
                new Training(){TrainingId=1,Status="yes"},
                new Training(){TrainingId=2,Status="yes"},
                new Training(){TrainingId=1,Status="yes"}


            };
        }
    }
}
