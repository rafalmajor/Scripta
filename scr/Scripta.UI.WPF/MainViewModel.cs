using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using Scripta.Domain;

namespace Scripta.UI.WPF;

public partial class MainViewModel : ObservableObject
{
    private Note _note = new Note
    {
        Id = Guid.NewGuid(),
        Title = "Note 1",
        Content = "This is a note 1"
    };
   
    [ObservableProperty]
    private string _title;
    
    [ObservableProperty]
    private string _description;

    public MainViewModel()
    {
        Title = _note.Title;
        Description = _note.Content;
    }
    
    [RelayCommand]
    private void ShowMessage()
    {
        MessageBox.Show(_note.Title, _note.Content, MessageBoxButton.OK, MessageBoxImage.Information);
    }
}