using ReactiveUI;

namespace Test.ViewModels;

public class ViewModelBase : ReactiveObject, IActivatableViewModel
{
    /// <inheritdoc />
    public ViewModelActivator Activator { get; }

    /// <summary>
    ///     Initializes object.
    /// </summary>
    public ViewModelBase()
    {
        Activator = new ViewModelActivator();
    }
}
