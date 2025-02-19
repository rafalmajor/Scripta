using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using Scripta.Domain;

namespace Scripta.UI.WPF;

public partial class MainViewModel : ObservableObject
{
    private readonly Note _note = new Note
    {
        Id = Guid.NewGuid(),
        Title = "Note 1",
        Content = "This is a note 1"
    };

    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private string _description;

    [ObservableProperty]
    private ObservableCollection<Note> _notes;

    public MainViewModel()
    {
        Title = _note.Title;
        Description = _note.Content;

        // Initialize the notes collection
        Notes = new ObservableCollection<Note>
        {
            new Note { Id = Guid.NewGuid(), Title = "Note 1", Content = "This is note 1" },
            new Note { Id = Guid.NewGuid(), Title = "Note 2", Content = "This is note 2" },
            new Note { Id = Guid.NewGuid(), Title = "Note 3", Content = "This is note 3" }
        };
    }

    [RelayCommand]
    private void ShowMessage()
    {
        MessageBox.Show(_note.Title, _note.Content, MessageBoxButton.OK, MessageBoxImage.Information);
    }
}