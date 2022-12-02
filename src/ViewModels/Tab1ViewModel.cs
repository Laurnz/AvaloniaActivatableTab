using System;
using System.Diagnostics;
using Moq;
using ReactiveUI;

namespace Test.ViewModels;

public class Tab1ViewModel : ViewModelBase
{
    public Tab1ViewModel()
    {
        this.WhenActivated(disposables =>
        {
            Debugger.Break(); // Activated

            Mock<IDisposable> mock = new();
            mock.Setup(x => x.Dispose())
                .Callback(() =>
                 {
                     Debugger.Break(); // Got deactivated
                 });

            disposables.Add(mock.Object);
        });
    }
}
