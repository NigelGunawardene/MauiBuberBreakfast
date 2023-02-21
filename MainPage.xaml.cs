using MauiBuberBreakfast.ViewModels;

namespace MauiBuberBreakfast;

public partial class MainPage : ContentPage
{

    public MainPage(MyBreakfastsViewModel mb)
    {
        InitializeComponent();
        BindingContext = mb;
    }

}

