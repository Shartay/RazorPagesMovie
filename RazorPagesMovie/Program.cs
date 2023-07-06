// The following lines of code in this file create a WebApplicationBuilder with preconfigured defaults, add Razor Pages support to the Dependency Injection (DI) container, and builds the app:
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Builds the app
var app = builder.Build();

// The following code sets the exception endpoint to /Error and enables HTTP Strict Transport Security Protocol (HSTS) when the app is not running in development mode:

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
