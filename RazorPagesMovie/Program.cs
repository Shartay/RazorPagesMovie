// Added by the scaffold process 
using System.Text; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// Added by the scaffold process 
builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesMovieContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesMovieContext' not found.")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // This line enables HTTPS redirection when the app is not running in development mode. Redirects HTTP requests to HTTPS.
app.UseStaticFiles(); // Enables static files, such as HTML, CSS, images, and JavaScript to be served.

app.UseRouting(); // Adds route matching to the middleware pipeline.

app.UseAuthorization(); //  Configures endpoint routing for Razor Pages.

app.MapRazorPages(); //  Authorizes a user to access secure resources. This app doesn't use authorization, therefore this line could be removed.

app.Run(); // Runs the app.
