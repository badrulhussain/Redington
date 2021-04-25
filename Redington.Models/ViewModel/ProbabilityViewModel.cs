using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Redington.Models.ViewModel
{
    public class ProbabilityViewModel
    {
        [Required]
        [Range(0.0, 1,
        ErrorMessage = "Value for {0} must be float between 0 to 1.")]
        public float A { get; set; }
        [Required]
        [Range(0.0, 1,
        ErrorMessage = "Value for {0} must be float between 0 to 1.")]
        public float B { get; set; }
        [Required]
        public string FunctionType { get; set; }
    }
}
