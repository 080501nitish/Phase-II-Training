using Microsoft.EntityFrameworkCore;
using StudentDetails.Context;
using StudentDetails.Services;
using StudentDetails.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentContext>(
    optionsAction:option => option.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "SqlServerConnection" )));

builder.Services.AddScoped<IStudent, StudentService>();

var app = builder.Build();


//Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();