using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambdaTraining.Models
{
    public class LambdaInput
    {
        public Guid LambdaInputId { get; set; }
        public string? LambdaInputString { get; set; }
    }
}
