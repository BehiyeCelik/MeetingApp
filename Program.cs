using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); // middleware i aktif eder ve wwwroot un altındaki dosyalar erişime açık olacak. 
app.UseRouting();// ekstra middleware ekledikten sonra sırasının doğru olmasını sağlar. şuanda bunu yazmaya gerek yoktu. 
//{Controller=Home}/{Action=Index}/Id? 
//app.MapDefaultControllerRoute();
app.MapControllerRoute(

    name: "default",
    pattern: "{Controller=home}/{Action=Index}/{id?}"

);

app.Run();
