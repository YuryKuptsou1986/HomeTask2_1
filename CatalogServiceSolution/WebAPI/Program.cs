using BLL;
using DAL;
using Model.Insert;
using Model.Update;

using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDALServices(builder.Configuration);
builder.Services.AddBLLServices();

builder.Services.AddControllers()
                .AddFluentValidation(options => {
                    options.RegisterValidatorsFromAssemblyContaining<CategoryInsertModelValidator>();
                    options.RegisterValidatorsFromAssemblyContaining<CategoryUpdateModelValidator>();
                    options.RegisterValidatorsFromAssemblyContaining<ItemInsertModelValidator>();
                    options.RegisterValidatorsFromAssemblyContaining<ItemUpdateModelValidator>();
                });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
