namespace Scripta.Domain;

public class Note
{
    public Guid Id { get; init; }
    public string Title { get; set; }
    public string Content { get; set; }
}
