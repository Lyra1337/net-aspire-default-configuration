using AspireConfigurationQuestion.ServiceDefaults;

namespace AspireConfigurationQuestion.ApiService
{
    public class SampleService(AppConfig appConfig, ILogger<SampleService> logger) : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.LogInformation("AppConfig.One: {One}", appConfig.One);
            logger.LogInformation("AppConfig.Two: {Two}", appConfig.Two);

            return Task.CompletedTask;
        }
    }
}
