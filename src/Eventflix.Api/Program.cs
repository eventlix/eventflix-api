using Elastic.Apm.NetCoreAll;
using Eventflix.Api.Extensions.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Host
    .AddLogs(builder.Configuration)
    .UseAllElasticApm();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
