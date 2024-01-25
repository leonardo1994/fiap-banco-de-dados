namespace Database006;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Password { get; set; }
    public int? GroupId { get; set; }
    public virtual Group? Group { get; set; }
}