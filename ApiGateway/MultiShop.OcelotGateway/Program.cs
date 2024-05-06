using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);


IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("ocelot.json").Build();
builder.Services.AddOcelot(configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

await app.UseOcelot();

app.Run();
