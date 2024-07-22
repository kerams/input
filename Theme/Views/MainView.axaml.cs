using Avalonia.Controls;

namespace Theme.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        tb.TextChanged += (s, e) => block.Text = ((TextBox)s).Text;
    }
}