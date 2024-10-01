using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RecipeCreator : MonoBehaviour
{
    /// <summary>
    /// FIRST INGREDIENT MUST BE BREAD!!!
    /// </summary>
    public List<Ingredient> validIngreds;
    public List<RawImage> recipeSlots;

    /*private Dictionary<string,int> ingredientRank = new Dictionary<string, int>
    {
        {"Bread",1 },
        {"Meat", 2 },
        {"Cheese",3 },
        {"Topping", 4 }
    };*/

    private void Start()
    {
        foreach(var pic in recipeSlots)
        {
            pic.texture = null;
        }
    }
    /// <summary>
    /// Using validIngreds List which is set in the Unity Editor, creates a "recipe"
    /// for a sandwhich. First element in your validIngreds should be your Bread object
    /// </summary>
    /// <returns>A List of Ingredient objects representing the recipe</returns>
    public List<Ingredient> makeRecipe()
    {
        List<Ingredient> recipe = new List<Ingredient>{ validIngreds[0] };
        int numIngred = Random.Range(2, 8);
        for(int i = 0;i<numIngred;i++)
        {
            recipe.Add(validIngreds[(int)Random.Range(1,5)]);
        }
        recipe.Add(validIngreds[0]);
        printRecipe(ref recipe);
        return recipe;

    }

    public void updateUI(List<Ingredient> recipe)
    {
        foreach (var pic in recipeSlots)
        {
            pic.texture = null;
        }
        for (int i = 0; i<recipe.Count;i++)
        {
            recipeSlots[i].texture = recipe[i].uiPic;
        }
    }

    public void gotIngredient(int i, Texture2D pic)
    {
        recipeSlots[i].texture = pic;
    }

    //IN PROGRESS!!!
    /*List<Ingredient> sortRecipe(ref List<Ingredient> recipe)
    {
        return recipe;
    }*/

   public void printRecipe(ref List<Ingredient> recipe)
    {
        for(int i = 0;i<recipe.Count;i++)
        {
            Debug.Log(recipe[i]);
        }
    }
}
