using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace FinancicalAccounting.Views;

public partial class MainWindow : ReactiveWindow<ViewModels.MainWindowViewModel>
{
    public static MainWindow Instance {get; private set;}
    public MainWindow()
    {
        InitializeComponent();
        Instance = this;
        //DataContext = new ViewModels.MainWindowViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}