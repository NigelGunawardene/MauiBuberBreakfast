# MauiBuberBreakfast

Roboto fonts included in Resources

Created Models and ViewModels. The breakfastsViewModel binds the list of breakfasts to the UI which is presented.

using MVVM

In MAUI, when we make a change to the view model and we want it to be reflected in the view again, we need to notify change happened
We use the .net community toolkit for this - 
Nuget Package - CommunityToolkit.Mvvm

This handles a lot of the magic for us. 
Implement ObservableObject in the MyBreakfastsViewModel and add the ObservableProperty attribute. Behind the scenes, it builds the public property for us and everytime we update that property, it notifies the view
(partial because the public property mentioned above is in the other partial class) This is evidenced in the LoadBreakfasts Method which updates the Breakfast property (capital B) when we declared it as breakfasts. Also check the implementation
to notice the new Breakfast property


Then we go to the main page to define the binding context. We take some data and bind it to the viewModel.

There are multiple ways to define the binding context, but here we will add this to the constructor - BindingContext = new MyBreakfastsViewModel();

Then in MainPage.xaml, we remove the existing content to add our own
We can think of our UI as 4 rows so define it as such

We can add common colors to Colors.xaml

BindingContext in the MainPage constructor was throwing an error. Had to register the page and the ViewModel in DI to get it working

We wrap our dinners area in a RefreshView tag. Then we add the RelayCommand annotation on the method called LoadBreakfasts and set LoadBreakfastsCommand as the Command when we execute the refresh

Now we create a converter for the date
Install CommunityToolkit.Maui nguet package

Create DateTimeToBreakfastDayConverter : BaseConverter<object, string>

After creating our 2 converters, we need to include them in the static resource dictionary (in styles.xaml) and then invoke them on the relevant parameters in the view and manipulate the UI
Then go to Program.cs and add UseMauiCommunityToolkit

Then update our xaml to use the converters






































