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
				typeof(IgbCategoryChartModule),
				typeof(IgbPieChartModule));
			ctx.Services.AddScoped<IFinancialService>(sp => new MockFinancialService());
			var componentUnderTest = ctx.RenderComponent<Charts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}