using Foody.BusinessLayer.Abstract;
using Foody.BusinessLayer.Concrete;
using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.EntityFramework;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//Bu kodun ne ise yaradigini tam bilmiyorum.
builder.Services.AddDbContext<FoodyContext>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ISliderDal, EfSliderDal>();
builder.Services.AddScoped<ISliderService, SliderManager>();
/*AutoMapper en ust surumunden 13.0.1 surumune indirince oldu.*/
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
/* BURAYA KADAR */



builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
