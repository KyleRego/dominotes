namespace dominotes.Models;

public class Recipe : EntityBase
{
    public ICollection<Step> Steps { get; set; } = [];
}