using RecipeBook.Models;
using Newtonsoft.Json;


namespace RecipeBook.Services;

public class RecipeService : IRecipeService
{
    private List<RecipeModel>? Recipes { get; set; }

    public RecipeService()
    {
        var json = File.ReadAllText("MockData/MockRecipes.json");
        Console.WriteLine(json);
        Recipes = JsonConvert.DeserializeObject<List<RecipeModel>>(json);
    }


    public List<RecipeModel> GetTopTenRecipes()
    {

        if (Recipes == null)
        {
            return new List<RecipeModel>();
        }

        var topTenRecipes = Recipes.OrderByDescending(r => r.Rating).Take(10).ToList();
        return topTenRecipes;
    }

    public void AddRecipe(RecipeModel recipesModelService)
    {
        throw new NotImplementedException();
    }

    public RecipeModel? GetRecipe(Guid recipeId)
    {
        return Recipes.FirstOrDefault(r => r.RecipeId == recipeId);
    }

    public List<RecipeModel>? GetRecipes()
    {
        return Recipes;
    }
}
