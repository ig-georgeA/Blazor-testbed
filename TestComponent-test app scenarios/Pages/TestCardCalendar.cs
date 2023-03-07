using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;

namespace TestComponent_test_app_scenarios
{
	public class TestCardCalendar
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbAvatarModule),
				typeof(IgbCalendarModule));
			var componentUnderTest = ctx.RenderComponent<CardCalendar>();
			Assert.NotNull(componentUnderTest);
		}
	}
}