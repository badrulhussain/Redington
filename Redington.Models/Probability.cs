using Redington.Models.ViewModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace Redington.Models
{
    public class Probability : ProbabilityViewModel
    {

        public float Result { get; set; }
        public DateTime Date { get; set; }
    }
}
