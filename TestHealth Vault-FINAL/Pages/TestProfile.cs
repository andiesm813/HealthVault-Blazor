using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Health_Vault_FINAL.Pages;

namespace TestHealth_Vault_FINAL
{
	public class TestProfile
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Profile>();
			Assert.NotNull(componentUnderTest);
		}
	}
}