var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Learnblazor>("learnblazor");

builder.Build().Run();
