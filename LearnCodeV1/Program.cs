using LearnCodeV1.Core.Repositories;
using LearnCodeV1.Core.Services;
using LearnCodeV1.Data.MyDb;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<myDb>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DbStrCon")
    ));
builder.Services.AddScoped<IMainService, MainRepo>();
builder.Services.AddScoped<ISendMessage , SendMessage>();
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
    pattern: "{area=Main}/{controller=Home}/{action=Home}/{id?}");

app.Run();
