using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace Scripta.UI.WPF;

public class MainViewModel
{
    public string Message { get; set; }

    public MainViewModel()
    {
        Message = "Hello, World!";
    }
    
}