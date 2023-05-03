using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Real_estate_market.Services;
using Real_estate_market.Services.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IAdvertiseService, AdvertiseService>();
builder.Services.AddTransient<IUserService, UserService>();


builder.Services.AddAutoMapper(typeof(IUserService));
//builder.Services.AddSingleton<IAdvertiseService, AdvertiseService>();
builder.Services.AddDbContext<RealEstateContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
