using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Audience.DAL.EF;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'AudienceContextConnection' not found.");

builder.Services.AddDbContext<AudienceDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllers();

app.Run();
