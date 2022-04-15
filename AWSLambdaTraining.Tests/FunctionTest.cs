using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using AWSLambdaTraining.Models;

namespace AWSLambdaTraining.Tests;

public class FunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {

        // Invoke the lambda function and confirm the string was upper cased.
        var function = new Function();
        var context = new TestLambdaContext();
        var lambdaInput = new LambdaInput
        {
            LambdaInputId = Guid.NewGuid(),
            LambdaInputString = "hello world"
        };
        var upperCase = function.FunctionHandler(lambdaInput, context);

        Assert.Equal("HELLO WORLD", upperCase);
    }
}
