using LabStore.Application;
using LabStore.Application.UseCases.Products.GetById;
using LabStore.Infraestructure;
using LabStore.Infraestructure.Data;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var conString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(conString, b => b.MigrationsAssembly("LabStore.API"));
});

builder.Services.AddInfra();
builder.Services.AddApplication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.MapControllers();

app.MapGet("v1/product/{id}", async (ISender sender, Guid id, CancellationToken token) =>
{
    var command = new GetByIdCommand(id);
    var result = await sender.Send(command, token);

    if (result.IsSuccess)
    {
        return Results.Ok(result.Value);
    }
    else
    {
        return Results.BadRequest(result.Error);
    }
});

app.Run();
