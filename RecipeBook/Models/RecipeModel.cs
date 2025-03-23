using System.ComponentModel;
using Newtonsoft.Json;

namespace RecipeBook.Models;

public class RecipeModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Instructions { get; set; }
    public int NumberOfIngredients { get; set; }
    public string[]? Ingredients { get; set; }
    public double Rating { get; set; }
    public Guid RecipeId { get; set; }
    public string? PictureUrl { get; set; }
}
