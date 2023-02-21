using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

    [RelayCommand]
    public void LoadBreakfasts()
    {
        Breakfasts = new()
        {
            new Breakfast
            (
                Name : "Vegan Sunshine",
                Description : "Vegan Sunshine",
                StartDateTime : DateTime.UtcNow.AddDays(1),
                EndDateTime : DateTime.UtcNow.AddDays(1).AddHours(1),
                Image : new Uri("https://images.unsplash.com/photo-1555939594-58d7cb561ad1?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=774&q=80"),
                Savory : new List < string >() { "Toast", "Toast", "Toast", "Toast" },
                Sweet : new List < string >() { "Cookie", "Cookie", "Cookie", "Cookie" }
            ),
            new Breakfast
            (
                Name : "Breakfast @ Tiffany's",
                Description : "Tiffany",
                StartDateTime : DateTime.UtcNow.AddDays(1),
                EndDateTime : DateTime.UtcNow.AddDays(1).AddHours(1),
                Image : new Uri("https://images.unsplash.com/photo-1482049016688-2d3e1b311543?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=820&q=80"),
                Savory : new List < string >() { "Salad" },
                Sweet : new List < string >() { "Waffle" }
            )
        };
    }
}
