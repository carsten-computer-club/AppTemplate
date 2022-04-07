using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using JaisAppCore;

namespace AppTemplate;

[App("AppTemplate", "/Assets/Icon.png")]
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}