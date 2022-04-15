using AWSLambdaTraining.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambdaTraining.Services
{
    public interface ILambdaService
    {
        string ProcessLambdInput(LambdaInput lambdaInput);
    }
}
