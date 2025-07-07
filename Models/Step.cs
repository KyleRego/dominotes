namespace dominotes.Models;

public class Step : EntityBase
{
    [Required]
    public required string RecipeId { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public Recipe Recipe { get; set; } = null!;
    public int Num { get; set; } = 1;
}