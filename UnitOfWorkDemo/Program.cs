using DataAccessEF;
using DataAccessEF.UnitOfWork;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var PeopleContextConnection = builder.Configuration.GetConnectionString("PaymentHub") ?? throw new InvalidOperationException("Connection string 'PaymentHub' not found.");

var DBSTGPassword = Environment.GetEnvironmentVariable("DBSTGPassword", EnvironmentVariableTarget.Machine).ToString();
builder.Services.AddDbContext<PeopleContext>(options => options.UseOracle(PeopleContextConnection + DBSTGPassword).LogTo(Console.WriteLine));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
