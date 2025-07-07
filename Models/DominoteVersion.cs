namespace dominotes.Models;

public class DominoteVersion
{
    public DateTime CreatedAt = DateTime.Now;
    [Required]
    public DominoteText Text { get; set; } = null!;
}