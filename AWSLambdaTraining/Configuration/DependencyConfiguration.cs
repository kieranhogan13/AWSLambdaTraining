using AWSLambdaTraining.Services;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace AWSLambdaTraining.Configuration
{
    public static class DependencyConfiguration
    {
        public static ServiceProvider BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ILambdaService, LambdaService>();
            serviceCollection.AddLogging(builder =>
            {
                var logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
                builder.AddSerilog(logger, true);
            });
            return serviceCollection.BuildServiceProvider();
        }
    }
}
