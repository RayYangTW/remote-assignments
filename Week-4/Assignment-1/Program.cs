using Assignment_1.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 增加與 DB 的連線
// 方法1 : 在appsetting.json增加 ConnectionString
// builder.Services.AddDbContext<assignmentContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

// 方法2 : 使用 DotNetEnv 套件將 ConnectionString 存在環境變數內
DotNetEnv.Env.Load();
var connectionString = System.Environment.GetEnvironmentVariable("ConnectionString");
builder.Services.AddDbContext<assignmentContext>(options =>
    options.UseSqlServer(connectionString));

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
