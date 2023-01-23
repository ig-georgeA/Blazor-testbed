using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Component_test_app_scenarios;
using Component_test_app_scenarios.Northwind;
using Component_test_app_scenarios.Financial;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<NorthwindService>();
builder.Services.AddScoped<FinancialService>();
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbNavDrawerItemModule),
        typeof(IgbTabsModule),
        typeof(IgbCardModule),
        typeof(IgbButtonModule),
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