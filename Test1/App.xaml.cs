namespace Test1;

using Microsoft.Maui.Handlers;

#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#elif __IOS__
using UIKit;
#endif

public partial class App
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }

}

