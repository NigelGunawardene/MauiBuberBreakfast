using CommunityToolkit.Maui;
using MauiBuberBreakfast.ViewModels;

namespace MauiBuberBreakfast;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Roboto-Bold.ttf", "Roboto-Bold");
                fonts.AddFont("Roboto-Regular.ttf", "Roboto-Regular");
            })
            .UseMauiCommunityToolkit();

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MyBreakfastsViewModel>();

        return builder.Build();
    }
}
