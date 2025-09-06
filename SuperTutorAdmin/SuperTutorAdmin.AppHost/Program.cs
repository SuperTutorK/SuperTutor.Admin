var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("SuperTutor")
    .WithDataVolume()
    .WithPgAdmin();

builder.AddProject<Projects.SuperTutorAdmin_API>("supertutoradmin-api")
    .WithReference(postgres);

builder.Build().Run();
