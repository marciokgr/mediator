using System.Reflection;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddMediatR(Assembly.GetExecutingAssembly()); //reference MediatR.Extensions.Microsoft.DependencyInjection
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
