using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Health_Vault_FINAL.Pages;
using Health_Vault_FINAL.PatientDashboard;

namespace TestHealth_Vault_FINAL
{
	public class TestHealthIndicators
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IPatientDashboardService>(sp => new MockPatientDashboardService());
			var componentUnderTest = ctx.RenderComponent<HealthIndicators>();
			Assert.NotNull(componentUnderTest);
		}
	}
}