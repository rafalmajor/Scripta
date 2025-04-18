using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using Scripta.Domain;

namespace Scripta.UI.WPF;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Note> _notes;
    
    [ObservableProperty]
    private Note _selectedNote;

    public MainViewModel()
    {
        // Initialize the notes collection
        Notes = new ObservableCollection<Note>
        {
            new Note { Id = Guid.NewGuid(), Title = "Note 1", Content = "This is note 1" },
            new Note { Id = Guid.NewGuid(), Title = "Note 2", Content = "This is note 2" },
            new Note { Id = Guid.NewGuid(), Title = "Note 3", Content = "This is note 3" },
            new Note { Id = Guid.NewGuid(), Title = "Note 4", Content = "This is note 4" }
        };

        SelectedNote = Notes.First();
    }

    [RelayCommand]
    private void Add()
    {
        Notes.Add(SelectedNote);
    }

    [RelayCommand]
    private void Remove()
    {
        Notes.Remove(SelectedNote);
    }
}