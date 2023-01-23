using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;
using Component_test_app_scenarios.Northwind;

namespace TestComponent_test_app_scenarios
{
	public class TestTablayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbIconButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbCalendarModule),
				typeof(IgniteUI.Blazor.Controls.IgbTabsModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbInputModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbGridModule),
				typeof(IgniteUI.Blazor.Controls.IgbCardModule),
				typeof(IgniteUI.Blazor.Controls.IgbGridModule),
				typeof(IgniteUI.Blazor.Controls.IgbGridModule));
			var mockHttpClient = new MockHttpClient().Create();
			ctx.Services.AddSingleton(new NorthwindService(mockHttpClient));
			var componentUnderTest = ctx.RenderComponent<Tablayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}