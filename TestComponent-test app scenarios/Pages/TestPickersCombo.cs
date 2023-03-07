using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;

namespace TestComponent_test_app_scenarios
{
	public class TestPickersCombo
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule));
			var componentUnderTest = ctx.RenderComponent<PickersCombo>();
			Assert.NotNull(componentUnderTest);
		}
	}
}