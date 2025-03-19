using RecipeBook.Models;
using Newtonsoft.Json;
using RecipeBook.Models;
using System.Collections.Generic;

namespace RecipeBook.Services;

public class RecipeService : IRecipeService
{
    private List<Recipe> recipes = null!;

    public RecipeService()
    {
        var json = File.ReadAllText("MockData/MockRecipes.json");
        Console.WriteLine(json);
        recipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
    }


    public List<Recipe> ReturnTopTenRecipes()
    {
        throw new NotImplementedException();
    }

    public void AddRecipe(Recipe recipesService)
    {
        throw new NotImplementedException();
    }

    public Recipe GetRecipe(Guid recipeId)
    {
        throw new NotImplementedException();
    }

    public List<Recipe> GetRecipes()
    {
        return recipes;
    }
}
