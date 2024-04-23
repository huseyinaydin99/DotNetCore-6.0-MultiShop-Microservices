using Microsoft.AspNetCore.Authentication.JwtBearer;
using MultiShop.Cargo.Business.Abstracts;
using MultiShop.Cargo.Business.Concrete;
using MultiShop.Cargo.Business.Concretes;
using MultiShop.Cargo.DataAccess.Abstracts;
using MultiShop.Cargo.DataAccess.Concretes;
using MultiShop.Cargo.DataAccess.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];//appsetting.json dosyas�ndan IdentityServer'�n URL'ini ald�k.
    opt.Audience = "ResourceCargo";//resourcecatalog key'ine sahip olan bir kullan�c� Catalog microservice'sinde i�lem yapabilecek.
    opt.RequireHttpsMetadata = false;//https gerekmesin.
});

builder.Services.AddDbContext<CargoContext>();
builder.Services.AddScoped<ICargoCompanyDal, EfCargoCompanyDal>();
builder.Services.AddScoped<ICargoCompanyService, CargoCompanyManager>();
builder.Services.AddScoped<ICargoCustomerDal, EfCargoCustomerDal>();
builder.Services.AddScoped<ICargoCustomerService, CargoCustomerManager>();
builder.Services.AddScoped<ICargoDetailDal, EfCargoDetailDal>();
builder.Services.AddScoped<ICargoDetailService, CargoDetailManager>();
builder.Services.AddScoped<ICargoOperationDal, EfCargoOperationDal>();
builder.Services.AddScoped<ICargoOperationService, CargoOperationManager>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();