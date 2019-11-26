using Mod.TechnologyServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TechnologyServices.Repository
{
   public interface ISkillsRepository
    {

        void Add(Skills item);
        void Update(Skills item);
        List<Skills> GetAll();
        Skills GetById(int id);
        void Delete(int id);

    }
}
