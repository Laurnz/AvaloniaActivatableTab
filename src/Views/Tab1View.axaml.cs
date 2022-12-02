using Avalonia.ReactiveUI;
using Test.ViewModels;

namespace Test.Views;

public partial class Tab1View : ReactiveUserControl<Tab1ViewModel>
{
    public Tab1View()
    {
        InitializeComponent();
    }
}
