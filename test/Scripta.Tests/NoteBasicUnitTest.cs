using Scripta.Domain;

namespace Scripta.Tests;

public class NoteBasicUnitTest
{
    [Fact]
    public void CreateNewEmptyNote()
    {
        //arrange
        
        //act
        var note = new Note
        {
            Title = null,
            Content = null
        };
        
        //assert
        Assert.Null(note.Title);
        Assert.Null(note.Content);
    }

    [Fact]
    public void CreateNewNote()
    {
        //arrange
        //act
        var note = new Note
        {
            Title = "Title", 
            Content = "Content"
        };
        
        //assert
        Assert.NotNull(note.Title);
        Assert.NotNull(note.Content);
    }

    [Fact]
    public void UpdateNoteTitle()
    {
        //arrange
        var note = new Note
        {
            Title = "Title",
            Content = "Content"
        };
        
        //act
        note.Title = "UpdatedTitle";
        
        //assert
        Assert.Equal("UpdatedTitle", note.Title);
    }
    
    [Fact]
    public void UpdateNoteContent()
    {
        //arrange
        var note = new Note
        {
            Title = "Title",
            Content = "Content"
        };
        
        //act
        note.Content = "UpdatedContent";
        
        //assert
        Assert.Equal("UpdatedContent", note.Content);
    }
}