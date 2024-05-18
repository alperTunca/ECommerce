using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Validators.OrderComment;
using ECommerce.Core.Domain.Entities;
using ECommerce.Infrastructure.Persistence;
using ECommerce.Infrastructure.Service.Filters;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers(x => x.Filters.Add<ValidationFilter>());
    //.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<CreateOrderCommentValidator>());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddPersistenceServices();

builder.Services.AddTransient<IValidator<CreateOrderComment>, CreateOrderCommentValidator>();
//builder.Services.AddTransient<IValidator<Product>, ProductValidator>();

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
