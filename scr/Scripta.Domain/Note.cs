namespace Scripta.Domain;

public class Note
{
    public Guid Id { get; init; }
    public required string Title { get; set; }
    public required string Content { get; set; }
}
