namespace dominotes.Models;

public class UserDominoteContribution : EntityBase
{

    [Required, ForeignKey(nameof(User))]
    public required string UserId { get; set; }
    public User? User { get; set; }

    [Required, ForeignKey(nameof(ContributedTo))]
    public required string DominoteId { get; set; }
    public Dominote? ContributedTo { get; set; }
}