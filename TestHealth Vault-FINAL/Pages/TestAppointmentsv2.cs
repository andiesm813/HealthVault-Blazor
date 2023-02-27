using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Health_Vault_FINAL.Pages;

namespace TestHealth_Vault_FINAL
{
	public class TestAppointmentsv2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbAvatarModule),
				typeof(IgbButtonModule));
			var componentUnderTest = ctx.RenderComponent<Appointmentsv2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}