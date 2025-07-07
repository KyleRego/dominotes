namespace dominotes.Models;

public class DominoteCategory : EntityBase
{
    [Required]
    public string Title { get; set; } = null!;

    public ICollection<Dominote> Dominotes { get; set; } = [];
}