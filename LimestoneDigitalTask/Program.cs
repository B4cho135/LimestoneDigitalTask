using Application;
using AutoMapper;
using Core.Persistance;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.AutoMapperProfiles;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new CreditInfoProfile());
});

IMapper mapper = mapperConfig.CreateMapper(); 
builder.Services.AddSingleton(mapper);

builder.Services.AddDbContext<DefaultDbContext>(
                    options => options.UseSqlServer("name=ConnectionStrings:Production"));



builder.Services.AddScoped<IIndividualService, IndividualService>();

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
