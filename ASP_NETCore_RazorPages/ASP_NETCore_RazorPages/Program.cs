var builder = WebApplication.CreateBuilder(args);

// Add a service to web container
builder.Services.AddRazorPages();
builder.Services.AddSession(opt=>opt.IdleTimeout = TimeSpan.FromMinutes(15));

var app = builder.Build();

// Enable to read wwwroot folder
app.UseStaticFiles();
app.UseSession();

// Mapping to Pages folder
app.MapRazorPages();

app.Run();
