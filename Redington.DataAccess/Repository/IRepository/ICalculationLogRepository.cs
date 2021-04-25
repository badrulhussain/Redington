using Redington.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redington.DataAccess.Repository.IRepository
{
    public interface ICalculationLogRepository
    {
        public void Create(Probability probability);
        public Probabilities GetAll();
    }
}
