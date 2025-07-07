namespace dominotes.Models;

public class User : IdentityUser
{
    public DateTime? CurrentTime { get; set; }

    public ICollection<Dominote> ContributedNotes { get; set; } = [];
}