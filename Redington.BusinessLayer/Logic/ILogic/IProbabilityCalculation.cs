using Redington.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redington.BusinessLayer.Logic.ILogic
{
    public interface IProbabilityCalculation
    {
        public float Get(Probability probability);
    }
}
