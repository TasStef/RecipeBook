namespace RecipeBook.Models;

public class Recipe
{
    public string RecipeName { get; set; }
    public string RecipeDescription { get; set; }
    public string RecipeInstructions { get; set; }
    public int NumberOfIngredients { get; set; }
    public double Rating { get; set; }
    public Guid RecipeId { get; set; }
}
