using Amazon.Lambda.Core;
using AWSLambdaTraining.Configuration;
using AWSLambdaTraining.Models;
using AWSLambdaTraining.Services;
using Microsoft.Extensions.DependencyInjection;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaTraining;

public class Function
{
    private IServiceProvider _serviceProvider;
    private ILambdaService _lambdaService;
    public Function()
    {
        _serviceProvider = DependencyConfiguration.BuildServiceProvider();
        _lambdaService = _serviceProvider.GetService<ILambdaService>();
    }
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(LambdaInput input, ILambdaContext context)
    {
        return _lambdaService.ProcessLambdInput(input);
    }
}
