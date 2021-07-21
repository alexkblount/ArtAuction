using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;

namespace ArtAuction
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseMauiApp<App>()                          
				.ConfigureServices(services =>
				{
					// here you register all your services for DI
				})
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("fasolid.otf", "FASolid"); // move you fonts from AssemblyInfo here
				});
		}
	}
}