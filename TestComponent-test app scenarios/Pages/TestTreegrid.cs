using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;
using Component_test_app_scenarios.Northwind;

namespace TestComponent_test_app_scenarios
{
	public class TestTreegrid
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbTreeGridModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new NorthwindService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Treegrid>();
			Assert.NotNull(componentUnderTest);
		}
	}
}