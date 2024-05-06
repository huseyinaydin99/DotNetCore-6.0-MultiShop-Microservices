using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication().AddJwtBearer("OcelotAuthenticationScheme", opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "ResourceOcelot";
    opt.RequireHttpsMetadata = false;
});

IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("Ocelot.json").Build();
builder.Services.AddOcelot(configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

await app.UseOcelot();

app.Run();
