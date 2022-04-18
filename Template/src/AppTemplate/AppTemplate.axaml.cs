using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using JaisAppCore;

namespace AppTemplate;

[App("AppTemplate", "avares://AppTemplate/Assets/Icon.png")]
public partial class AppTemplate : UserControl
{
    public AppTemplate()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}