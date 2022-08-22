using System.Reflection;
using MediatR;
using mediator.Infrastructure.Data;
var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddMediatR(Assembly.GetExecutingAssembly()); //reference MediatR.Extensions.Microsoft.DependencyInjection
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddDbContext<MyDataContext>();
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
