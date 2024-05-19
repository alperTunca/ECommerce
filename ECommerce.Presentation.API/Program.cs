using System.Reflection;
using ECommerce.Core.Application;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Validators.OrderComment;
using ECommerce.Core.Domain.Entities;
using ECommerce.Infrastructure.Persistence;
using ECommerce.Infrastructure.Service.Filters;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers(x => x.Filters.Add<ValidationFilter>());
    //.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<CreateOrderCommentValidator>());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// TODO - Mediatr pattern implemente
// Proje küçük çapta olduğu için service layer'ı yazmak yerine repo objeleri direk mediatr içinden erişilebilir yapıldı.
// DB servisi dışında servisler dahil olsaydı layer ı eklemek daha mantıklı olurdu.

builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();

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
