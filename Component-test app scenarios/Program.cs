using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Component_test_app_scenarios;
using Component_test_app_scenarios.Northwind;
using Component_test_app_scenarios.Financial;
using IgniteUI.Blazor.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();


builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(sp.GetRequiredService<IWebHostEnvironment>()));
builder.Services.AddScoped<IFinancialService>(sp => new FinancialService(sp.GetRequiredService<IWebHostEnvironment>()));
RegisterIgniteUI(builder.Services);

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule),
        typeof(IgbButtonModule),
        typeof(IgbTabsModule),
        typeof(IgbCardModule),
        typeof(IgbCalendarModule),
        typeof(IgbInputModule),
        typeof(IgbGridModule),
        typeof(IgbAvatarModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbListModule),
        typeof(IgbCheckboxModule),
        typeof(IgbTreeModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbTreeGridModule),
        typeof(IgbPivotDataSelector),
        typeof(IgbCategoryChartModule),
        typeof(IgbPieChartModule),
        typeof(IgbDatePickerModule),
        typeof(IgbChipModule),
        typeof(IgbSliderModule),
        typeof(IgbRangeSliderModule),
        typeof(IgbSwitchModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbSnackbarModule)
    );
}

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
