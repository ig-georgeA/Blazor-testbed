using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;

namespace TestComponent_test_app_scenarios
{
	public class TestInputs
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbDatePickerModule),
				typeof(IgbChipModule),
				typeof(IgbSliderModule),
				typeof(IgbRangeSliderModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbSwitchModule),
				typeof(IgbCheckboxModule),
				typeof(IgbRadioGroupModule),
				typeof(IgbRadioModule),
				typeof(IgbAvatarModule));
			var componentUnderTest = ctx.RenderComponent<Inputs>();
			Assert.NotNull(componentUnderTest);
		}
	}
}