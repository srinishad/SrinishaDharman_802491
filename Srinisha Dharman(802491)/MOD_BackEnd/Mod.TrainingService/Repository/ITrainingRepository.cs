using Mod.TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TrainingService.Repository
{
    public interface ITrainingRepository
    {
        void Add(Training item);
        void Update(Training item);
        List<Training> GetAll();
        Training GetById(int id);
        void Delete(int id);
        List<Training> GetTrainingByUserId(int id);
        List<Training> GetTrainingByMentorId(int id);
    }
}
