using WaterBucketChallenge.Application.Interfaces;
using WaterBucketChallenge.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

//Ver tipos de ciclo de vida scoped vs transient vs singleton
builder.Services.AddScoped<IWaterBucketService, WaterBucketService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/health"); 

app.Run();