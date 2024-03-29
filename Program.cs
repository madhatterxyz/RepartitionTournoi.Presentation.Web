﻿using RepartitionTournoi.Presentation.Web.Services;
using RepartitionTournoi.Presentation.Web.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<ITournoiServices, TournoiServices>();
builder.Services.AddScoped<IScoreServices, ScoreServices>();
builder.Services.AddScoped<IMatchServices, MatchServices>();
builder.Services.AddScoped<IJoueurServices, JoueurServices>();
builder.Services.AddScoped<IJeuServices, JeuServices>();
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
