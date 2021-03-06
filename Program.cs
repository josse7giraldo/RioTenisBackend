using Microsoft.EntityFrameworkCore;
using Rio.Tenis.Backend.DBContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string mySqlConnectionStr = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextPool<RioTenisDBContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
