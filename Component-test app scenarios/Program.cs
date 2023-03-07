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
builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<IFinancialService>(sp => new FinancialService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
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
        typeof(IgbButtonModule),
        typeof(IgbTabsModule),
        typeof(IgbCardModule),
        typeof(IgbCalendarModule),
        typeof(IgbInputModule),
        typeof(IgbGridModule),
        typeof(IgbDataGridToolbarModule),
        typeof(IgbAvatarModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbListModule),
        typeof(IgbCheckboxModule),
        typeof(IgbTreeModule),
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