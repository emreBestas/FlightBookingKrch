using FlightBookingKrch.Services.BookingServices;
using FlightBookingKrch.Services.CheckInServices;
using FlightBookingKrch.Services.FlightServices;
using FlightBookingKrch.Services.MachineLearningServices;
using FlightBookingKrch.Services.NoShowServices;
using FlightBookingKrch.Services.NoShowServices.FlightBooking.Services.NoShowServices;
using FlightBookingKrch.Services.OverBookingNoShowServices;
using FlightBookingKrch.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<ICheckInService, CheckInService>();

builder.Services.AddScoped<NoShowPredictionService>();
builder.Services.AddScoped<OverbookingRecommendationService>(); 
builder.Services.AddScoped<NoShowService>();
builder.Services.AddSingleton<FlightRegressionService>();
builder.Services.AddSingleton<FlightMlService>();
builder.Services.AddScoped<MongoFlightDataService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));
builder.Services.AddScoped<IDatabaseSettings>(sp => { return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value; });

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();


app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();