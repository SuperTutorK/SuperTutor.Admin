using Domain.Entities;
using Identity;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddAuthorization();

builder.Services
    .AddDbContext(builder.Configuration.GetConnectionString("DataBase") ?? throw new ArgumentException("DataBase connection string is null"))
    .AddIdentity().AddIdentityApiEndpoints<User>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

app
    .UseAuthentication()
    .UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapIdentityApi<User>();

app.Run();