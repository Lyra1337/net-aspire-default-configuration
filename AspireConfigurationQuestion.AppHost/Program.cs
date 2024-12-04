var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireConfigurationQuestion_ApiService>("apiservice");

builder.AddProject<Projects.AspireConfigurationQuestion_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
