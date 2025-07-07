namespace dominotes.Models;

public class FoodVariant : EntityBase
{
    public int TotalToppings { get; set; } = 0;
    public decimal Cost { get; set;  }
    public ICollection<Ingredient> Toppings { get; set; } = [];
}