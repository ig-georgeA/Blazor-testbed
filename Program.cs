using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IgniteUI.Blazor.Controls;
using ComponentTestbed;
using ComponentTestbed.Northwind;
using ComponentTestbed.Northwind_Jason;
using ComponentTestbed.Financial;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<NorthwindService>();
builder.Services.AddScoped<Northwind_JasonService>();
builder.Services.AddScoped<FinancialService>();

RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbButtonModule),
        typeof(IgbIconModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule),
        typeof(IgbCardModule),
        typeof(IgbAvatarModule),
        typeof(IgbInputModule),
        typeof(IgbCheckboxModule),
        typeof(IgbListModule),
        typeof(IgbDataGridModule),
        typeof(IgbDataGridToolbarModule),
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