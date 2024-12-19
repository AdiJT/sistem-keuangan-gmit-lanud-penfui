using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Options;
using SIKeuanganGMITLanudPenfui.Application;
using SIKeuanganGMITLanudPenfui.Infrastructure;
using SIKeuanganGMITLanudPenfui.Infrastructure.Configurations;
using SIKeuanganGMITLanudPenfui.Web.Services.Toastr;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<FileConfigurationOptions>(builder.Configuration.GetSection(FileConfigurationOptions.FileConfiguration));
builder.Services.AddScoped((sp) =>
{
    return sp.GetRequiredService<IOptionsSnapshot<FileConfigurationOptions>>().Value;
});

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.Services.AddControllersWithViews().AddSessionStateTempDataProvider();

builder.Services.AddRazorTemplating();

builder.Services.AddSession();

builder.Services.AddScoped<IToastrNotificationService, ToastrNotificationService>();

var app = builder.Build();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseStatusCodePagesWithReExecute("/Home/StatusCode{0}");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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

app.UseSession();

app.MapAreaControllerRoute(
    name: "Dashboard",
    areaName: "Dashboard",
    pattern: "Dashboard/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
