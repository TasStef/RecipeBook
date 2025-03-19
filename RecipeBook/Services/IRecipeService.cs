using RecipeBook.Models;

namespace RecipeBook.Services;

public interface IRecipeService
{
    List<Recipe> ReturnTopTenRecipes();
    void AddRecipe(Recipe recipesService);
    Recipe GetRecipe(Guid recipeId);
    public List<Recipe> GetRecipes();
}

