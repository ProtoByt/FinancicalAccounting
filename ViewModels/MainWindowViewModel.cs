using ReactiveUI.Fody.Helpers;
using ReactiveUI;
using System.Reactive;


namespace FinancicalAccounting.ViewModels;

public partial class MainWindowViewModel : ViewModelBase, IScreen
{
    public MainWindowViewModel()
    {
        Router = new RoutingState();
        ClickCommand = ReactiveCommand.Create(OnClick);
        Greeting = "Welcome to Avalonia!";
    }
    [Reactive] public ReactiveCommand<Unit, Unit> ClickCommand { get; set; }
    [Reactive] public string Greeting { get; set; }

    [Reactive] public RoutingState Router { get; set; } 

    private void OnClick()
    {
        Greeting = "You clicked the button!";
    }
}
