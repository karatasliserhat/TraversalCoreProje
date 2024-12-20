using TraversolCoreProje.WebUI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();




builder.Services.AddService(builder.Configuration);


var app = builder.Build();
var lf = app.Services.GetRequiredService<ILoggerFactory>();
var path = Directory.GetCurrentDirectory();

lf.AddFile($"{path}\\Logs\\logger1.txt");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
     name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();
