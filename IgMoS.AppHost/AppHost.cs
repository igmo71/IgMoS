var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.IgMoS_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.IgMoS_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.AddProject<Projects.IgMoS_WMS>("igmos-wms");

builder.Build().Run();
