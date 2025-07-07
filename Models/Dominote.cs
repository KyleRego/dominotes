namespace dominotes.Models;

public class Dominote : EntityBase
{
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool RecipeStep { get; set; } = false;
    public bool Food { get; set; }
    public bool Misc { get; set; }

    public ICollection<DominoteCategory> Categories = [];
}