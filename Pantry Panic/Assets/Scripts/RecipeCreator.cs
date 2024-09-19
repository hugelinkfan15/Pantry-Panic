using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RecipeCreator : MonoBehaviour
{
    /// <summary>
    /// FIRST INGREDIENT MUST BE BREAD!!!
    /// </summary>
    public List<Ingredient> validIngreds;

    private Dictionary<string,int> ingredientRank = new Dictionary<string, int>
    {
        {"Bread",1 },
        {"Meat", 2 },
        {"Cheese",3 },
        {"Topping", 4 }
    };

    /// <summary>
    /// Using validIngreds List which is set in the Unity Editor, creates a "recipe"
    /// for a sandwhich. First element in your validIngreds should be your Bread object
    /// </summary>
    /// <returns>A List of Ingredient objects representing the recipe</returns>
   public List<Ingredient> makeRecipe()
    {
        List<Ingredient> recipe = new List<Ingredient>{ validIngreds[0] };
        int numIngred = Random.Range(2, 9);
        for(int i = 0;i<numIngred;i++)
        {
            recipe.Add(validIngreds[(int)Random.Range(1,5)]);
        }
        recipe.Add(validIngreds[0]);
        //Uncomment to Test loop
        printRecipe(ref recipe);
        return recipe;

    }

    //IN PROGRESS!!!
    List<Ingredient> sortRecipe(ref List<Ingredient> recipe)
    {
        return recipe;
    }

   public void printRecipe(ref List<Ingredient> recipe)
    {
        for(int i = 0;i<recipe.Count;i++)
        {
            Debug.Log(recipe[i]);
        }
    }
}
