﻿using RecipeBook.Models;

namespace RecipeBook.Services;

public interface IRecipeService
{
    List<RecipeModel>? GetTopTenRecipes();
    void AddRecipe(RecipeModel recipesModelService);
    RecipeModel? GetRecipe(Guid recipeId);
    public List<RecipeModel>? GetRecipes();
}

