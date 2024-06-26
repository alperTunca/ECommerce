using System.Reflection;
using System.Text.Json.Serialization;
using ECommerce.Core.Application;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Validators.OrderComment;
using ECommerce.Core.Domain.Entities;
using ECommerce.Infrastructure.Persistence;
using ECommerce.Infrastructure.Service.Filters;
using FluentValidation;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers(x => x.Filters.Add<ValidationFilter>())
    .AddJsonOptions(options =>
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()))
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateOrderCommentValidator>());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Since the project was small-scale, service layer was not implemented.
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();

// For website access :)
builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(x =>
    {
        x
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
