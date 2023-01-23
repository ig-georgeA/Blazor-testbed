using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;
using Component_test_app_scenarios.Financial;

namespace TestComponent_test_app_scenarios
{
	public class TestCharts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbCategoryChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbPieChartModule),
				typeof(IgniteUI.Blazor.Controls.IgbPieChartModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new FinancialService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Charts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}