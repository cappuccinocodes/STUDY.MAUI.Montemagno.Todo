using Maui.Montemagno.Todo.ViewModels;

namespace Maui.Montemagno.Todo;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}