using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Mod.TechnologyServices.Repository;
using Mod.TechnologyServices.Models;
using Mod.TechnologyServices.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MOD.UnitTesting
{
   public class TechControllerTest
    {
        private readonly Mock<ISkillsRepository> _repo;
        private readonly SkillsController _controller;
        public TechControllerTest()
        {
            _repo = new Mock<ISkillsRepository>();
            _controller = new SkillsController(_repo.Object);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetSkills());
            var result = _controller.Get() as List<Skills>;
            Assert.Equal(3, result.Count);

        }
        [Fact]
        public void GetById()
        {
            _repo.Setup(m => m.GetById(1)).Returns(GetSkills()[0]);
            var result = _controller.Get(1) as Skills;
            Assert.NotNull(result);
            Assert.Equal(1, result.SkillId);
        }
        [Fact]
        public void Post()
        {
            var item = GetSkills()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void put()
        {
            var item = GetSkills()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.Delete(It.IsAny<int>()));
            var result = _controller.Delete(1) as OkResult;
            Assert.NotNull(result);
        }
        private List<Skills> GetSkills()
        {
            return new List<Skills>()
            {
                new Skills(){SkillId=1,SkillName="Java"},
                 new Skills(){SkillId=2,SkillName="iot"},
                  new Skills(){SkillId=3,SkillName="Java3"}
            };
        }
        

        
    }
}
