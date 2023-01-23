using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Component_test_app_scenarios.Pages;

namespace TestComponent_test_app_scenarios
{
	public class TestLayouts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor();
			var componentUnderTest = ctx.RenderComponent<Layouts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}