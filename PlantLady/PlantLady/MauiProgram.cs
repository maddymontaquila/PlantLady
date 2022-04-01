namespace PlantLady;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("AmaticSC-Regular.ttf", "Amatic");
                fonts.AddFont("materialdesignicons-webfont.ttf","MaterialIcons");
                fonts.AddFont("Michella-Garden.otf", "Michella");
			});

		return builder.Build();
	}
}
