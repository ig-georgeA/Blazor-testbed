using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;

namespace TestComponent_test_app_scenarios
{
	public class TestExpansionpanelstree
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbAvatarModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbListModule),
				typeof(IgbInputModule),
				typeof(IgbCheckboxModule),
				typeof(IgbTreeModule));
			var componentUnderTest = ctx.RenderComponent<Expansionpanelstree>();
			Assert.NotNull(componentUnderTest);
		}
	}
}