namespace BugStore.Models;

public class Customer
{
    public Guid Id { get; set; }
    public required string Name { get; set; } = string.Empty;
    public required string Email { get; set; } = string.Empty;
    public required string Phone { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
}