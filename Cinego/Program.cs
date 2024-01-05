using Cinego.Data;
using Cinego.Data.Services;
using Cinego.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CinegoDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IActorsService, ActorsService>();
builder.Services.AddScoped<IDirectorsService, DirectorService>();
builder.Services.AddScoped<ICinemasService, CinemasService>();
builder.Services.AddScoped<IMoviesService, MovieService>();
builder.Services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
builder.Services.AddScoped(sc=>Cart.GetCart(sc));
builder.Services.AddScoped<IOrdersService, OrderService>();



//Authorization type services
builder.Services.AddIdentity<User,IdentityRole>().AddEntityFrameworkStores<CinegoDbContext>();

builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(option =>
{
	option.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
DbInit.SeedUsersAndRolesAsync(app).Wait();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
