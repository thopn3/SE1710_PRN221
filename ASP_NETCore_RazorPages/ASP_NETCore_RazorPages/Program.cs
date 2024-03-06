using ASP_NETCore_RazorPages;
using ASP_NETCore_RazorPages.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add a service to web container
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddSession(opt=>opt.IdleTimeout = TimeSpan.FromMinutes(15));

builder.Services.AddDbContext<SE1710_DBContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("SE1710")));

var app = builder.Build();

// Enable to read wwwroot folder
app.UseStaticFiles();
app.UseSession();

// Mapping to Pages folder
app.MapRazorPages();
app.MapHub<HubServer>("/hub");

app.Run();
