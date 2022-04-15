using AWSLambdaTraining.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambdaTraining.Services
{
    public class LambdaService :ILambdaService
    {
        private ILogger<LambdaService> _logger;
        public LambdaService(ILogger<LambdaService> logger)
        {
            _logger = logger;
        }

        public string ProcessLambdInput(LambdaInput lambdaInput)
        {
            _logger.LogInformation($"Processing Lambda input for LambdaInputId: {lambdaInput.LambdaInputId}");
            var processResult = lambdaInput.LambdaInputString.ToUpperInvariant();
            _logger.LogInformation($"Process result: {processResult}");
            return processResult;
        }
    }
}
