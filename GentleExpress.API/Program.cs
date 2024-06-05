using GentleExpress.Repositories.EfCore;
using GentleExpress.Services.Abstraction.Services;
using GentleExpress.Services.EFCore.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GentleExpressPostgresDbContext>(opt =>
        opt.UseNpgsql(builder.Configuration.GetConnectionString("GentleExpressDbConnection")));
builder.Services.AddScoped<ICouriersService, CouriersService>();
builder.Services.AddScoped<ICitiesService, CitiesService>();
builder.Services.AddScoped<IDistrictsService, DistrictsService>();
builder.Services.AddScoped<IVendorsService, VendorsService>();
builder.Services.AddScoped<IVendorAddressesService, VendorAddressesService>();


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
