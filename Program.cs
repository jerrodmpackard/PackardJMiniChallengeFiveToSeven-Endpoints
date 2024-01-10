using PackardJMiniChallengeFiveToSeven_Endpoints.Services.MadLibs;
using PackardJMiniChallengeFiveToSeven_Endpoints.Services.OddOrEven;
using PackardJMiniChallengeFiveToSeven_Endpoints.Services.ReverseInteger;
using PackardJMiniChallengeFiveToSeven_Endpoints.Services.ReverseString;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IMadLibsService, MadLibsService>();
builder.Services.AddScoped<IReverseStringService, ReverseStringService>();
builder.Services.AddScoped<IReverseIntegerService, ReverseIntegerService>();

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
