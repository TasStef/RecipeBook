using RecipeBook.Models;

namespace RecipeBook.Services;

public interface IRecipeService
{
    List<RecipeModel>? ReturnTopTenRecipes();
    void AddRecipe(RecipeModel recipesModelService);
    RecipeModel? GetRecipe(Guid recipeId);
    public List<RecipeModel>? GetRecipes();
}

