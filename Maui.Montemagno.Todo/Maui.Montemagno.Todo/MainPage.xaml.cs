using Maui.Montemagno.Todo.ViewModels;

namespace Maui.Montemagno.Todo;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

