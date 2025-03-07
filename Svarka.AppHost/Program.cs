var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Svarka_ApiService>("apiservice");

builder.AddProject<Projects.Svarka_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
