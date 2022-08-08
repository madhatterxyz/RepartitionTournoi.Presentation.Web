using RepartitionTournoi.Presentation.Web.Services;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
<<<<<<< HEAD
builder.Services.AddScoped<ITournoiServices, TournoiServices>();
builder.Services.AddScoped<IJoueurServices, JoueurServices>();
builder.Services.AddScoped<IJeuServices, JeuServices>();
=======
builder.Services.AddScoped<IJoueurServices, JoueurServices>();

>>>>>>> a308204964aefca51c0fa08b72372dbb5aafa0c5
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

app.Run();
