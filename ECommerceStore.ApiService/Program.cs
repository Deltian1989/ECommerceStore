using ECommerceStore.Core.DTOS;
using ECommerceStore.Core.Entities;
using ECommerceStore.Core.Interfaces;
using ECommerceStore.Infrastructure.Persistence;
using ECommerceStore.Infrastructure.Repositories;
using ECommerceStore.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

var connextionString = builder.Configuration.GetConnectionString("ECommerceConnectionString");

builder.Services.AddSqlServer<ApplicationDbContext>(connextionString);

// Add services to the container
builder.Services.AddControllers(); // Enables controllers and API endpoints

// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddAutoMapper(config => {
    config.CreateMap<Product, ProductDto>()
    .ForMember(d => d.DiscountPercentage, config => config.Ignore())
    .ForMember(d => d.PriceWithDiscount, config => config.Ignore())
    .AfterMap((s, d) => {
        d.DiscountPercentage = (int)(s.Discount * 100);
        d.PriceWithDiscount = Math.Round(s.UnitPrice - s.UnitPrice * s.Discount, 2, MidpointRounding.ToZero);
    }
    );
} 
);

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
