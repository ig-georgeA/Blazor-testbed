using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;

namespace TestComponent_test_app_scenarios
{
	public class TestDialogsandoverlays
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbButtonModule),
				typeof(IgniteUI.Blazor.Controls.IgbRippleModule),
				typeof(IgniteUI.Blazor.Controls.IgbSnackbarModule));
			var componentUnderTest = ctx.RenderComponent<Dialogsandoverlays>();
			Assert.NotNull(componentUnderTest);
		}
	}
}