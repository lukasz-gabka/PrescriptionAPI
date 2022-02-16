using Microsoft.EntityFrameworkCore;
using PrescriptionAPI;
using PrescriptionAPI.Entities;
using PrescriptionAPI.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApiDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DbUpdater>();
builder.Services.AddScoped<PrescriptionService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var scope = app.Services.CreateScope();
var dbUpdater = scope.ServiceProvider.GetRequiredService<DbUpdater>();
dbUpdater.Update();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
