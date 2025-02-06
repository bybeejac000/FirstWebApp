var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


//setup the server file
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default"
    ,pattern: "{controller=sub}/{action=Index}/{id?}");




app.Run();
