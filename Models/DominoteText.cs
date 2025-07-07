namespace dominotes.Models;

public class DominoteText : EntityBase
{
    [Required]
    public string Text { get; set; } = null!;
}