var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Catalyst4Change_ApiService>("apiservice");

builder.AddProject<Projects.Catalyst4Change_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
