using Redington.BusinessLayer.Logic.ILogic;
using Redington.DataAccess.Repository.IRepository;
using Redington.Models;
using Redington.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redington.BusinessLayer.Logic
{
    public class ProbabilityCalculation : IProbabilityCalculation
    {
        private readonly ICalculationLogRepository _calculationLogRepository;
        public ProbabilityCalculation(ICalculationLogRepository calculationLogRepository)
        {
            this._calculationLogRepository = calculationLogRepository;
        }

        public float Get(Probability probability)
        {
            probability.Date = DateTime.Now.Date;

            if(probability.FunctionType == SD.Function1)
            {
                probability.Result = probability.A * probability.B;
                probability.FunctionType = SD.Function1;
            }
            else
            {
                probability.Result = probability.A + probability.B - (probability.A * probability.B);
                probability.FunctionType = SD.Function2;
            }

            _calculationLogRepository.Create(probability);

            return probability.Result;
        }
    }
}
