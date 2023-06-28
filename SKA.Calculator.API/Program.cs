using Microsoft.EntityFrameworkCore;
using SKA.Calculator.Application.Commands.CalculateCommands.Calculate;
using SKA.Calculator.Application.Queries.Getall;
using SKA.Calculator.Domain.Interfaces;
using SKA.Calculator.Infrastructure.EntityFramework.Context;
using SKA.Calculator.Infrastructure.EntityFramework.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(cfg => cfg.AllowNullCollections = true);
string? SqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<HistoryCalculationsDbContext>(options => options.UseSqlServer(SqlConnection, x => x.MigrationsHistoryTable("__MyMigrationsHistory", "Calculator"))
                                            , ServiceLifetime.Scoped);

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CalculateCommand).Assembly));
builder.Services.AddAutoMapper(typeof(GetAllCalculatorControllerQuery).Assembly);

builder.Services.AddScoped<ICalculatorRepository, CalculatorRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(build =>
    {
        build.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
