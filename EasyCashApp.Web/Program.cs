using EasyCashApp.Business.Abstract;
using EasyCashApp.Business.Concrete;
using EasyCashApp.DataAccess.Abstract;
using EasyCashApp.DataAccess.Concrete;
using EasyCashApp.DataAccess.EntityFramework;
using EasyCashApp.Entity.Concrete;
using EasyCashApp.Web.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>();//Registration islemi gerceklestirmek icin services e eklendi
builder.Services.AddIdentity<AppUser, AppRole>()
	.AddEntityFrameworkStores<Context>()
	.AddErrorDescriber<CustomIdentityValidator>();//EasyCashApp.Web.Models türkce hata mesajlarini burada tanitiyoruz

//Para transfer islemi icin tanimlama yapildi.
builder.Services.AddScoped<ICustomerAccountProcessDal, efCustomerAccountProcessDal>();
builder.Services.AddScoped<ICustomerAccountProcessService,CustomerAccountProcessManager>();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
