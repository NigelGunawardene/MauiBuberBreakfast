using CommunityToolkit.Mvvm.ComponentModel;
using MauiBuberBreakfast.Models;

namespace MauiBuberBreakfast.ViewModels;
public partial class MyBreakfastsViewModel : ObservableObject
{
    [ObservableProperty]
    List<Breakfast> breakfasts;

    public MyBreakfastsViewModel()
    {
        LoadBreakfasts();
    }

    private void LoadBreakfasts()
    {
        Breakfasts = new()
        {
            new Breakfast
            (
                Name : "Vegan Sunshine",
                Description : "Vegan Sunshine",
                StartDateTime : DateTime.UtcNow.AddDays(1),
                EndDateTime : DateTime.UtcNow.AddDays(1).AddHours(1),
                Image : new Uri("https://unsplash.com/photos/UC0HZdUitWY"),
                Savory : new List < string >() { "Toast" },
                Sweet : new List < string >() { "Cookie" }
            ),
            new Breakfast
            (
                Name : "Breakfast @ Tiffany's",
                Description : "Tiffany",
                StartDateTime : DateTime.UtcNow.AddDays(1),
                EndDateTime : DateTime.UtcNow.AddDays(1).AddHours(1),
                Image : new Uri("https://unsplash.com/photos/fdlZBWIP0aM"),
                Savory : new List < string >() { "Salad" },
                Sweet : new List < string >() { "Waffle" }
            )
        };
    }
}
