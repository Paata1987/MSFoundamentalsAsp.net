using ContrcrWebsite.Models;
using ContrcrWebsite.Services;
using Microsoft.AspNetCore.Builder;
using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();
builder.Services.AddTransient<JsonFileProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapBlazorHub();


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapRazorPages();
//    endpoints.MapControllers();
//    endpoints.MapBlazorHub();




//    //        // endpoints.MapGet("/products", (context) => 
//    //        // {
//    //        //     var products = app.ApplicationServices.GetService<JsonFileProductService>().GetProducts();
//    //        //     var json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
//    //        //     return context.Response.WriteAsync(json);
//    //        // });
//});

app.Run();
