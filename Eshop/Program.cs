using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Contracts.Repository;
using Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TrainingDbContext>(option => {

    option.UseSqlServer(builder.Configuration.GetConnectionString("TrainingDB"));
});

builder.Services.AddScoped<IProductRepositoryAsync, ProductRepositoryAsync>();
builder.Services.AddScoped<IShipperRepositoryAsync, ShipperRepositoryAsync>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepositoryAsync>();
builder.Services.AddScoped<IReviewRepositoryAsync, ReviewRepositoryAsync>();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
