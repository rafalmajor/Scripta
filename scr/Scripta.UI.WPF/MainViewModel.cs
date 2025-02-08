using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace Scripta.UI.WPF;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string _message;

    public MainViewModel()
    {
        Message = "Hello, World!";
    }
    
    [RelayCommand]
    private void ShowMessage()
    {
        MessageBox.Show(Message);
    }
}