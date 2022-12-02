using System;
using System.Diagnostics;
using Moq;
using ReactiveUI;

namespace Test.ViewModels;

public class Tab1ViewModel : ViewModelBase
{
    public string Text { get; } = "Loo";

    public Tab1ViewModel()
    {

    }
}
