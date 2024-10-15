using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

/// <summary>
/// Used to Create a List of Ingredients with helper functions to display UI images
/// </summary>
public class RecipeCreator : MonoBehaviour
{
    /// <summary>
    /// FIRST INGREDIENT MUST BE BREAD!!!
    /// </summary>
    public List<Ingredient> validIngreds;
    [Header("UI Panel Slots")]
    public List<RawImage> recipeSlots;
    public List<RawImage> keySlots;

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

    /// <summary>
    /// Using a given List of RawImages, resets all the textures in the RawImages, and the sets the a number of the Raw Images
    /// depending on how many Ingredients are in the given List
    /// </summary>
    /// <param name="recipe"></param>
    public void updateUI(List<Ingredient> recipe)
    {
        foreach (var pic in recipeSlots)
        {
            pic.texture = null;
        }
        foreach (var pic in keySlots)
        {
            pic.texture = null;
        }
        for (int i = 0; i<recipe.Count;i++)
        {
            recipeSlots[i].texture = recipe[i].uiPic;
        }
        for (int i = 0; i < recipe.Count; i++)
        {
            keySlots[i].texture = recipe[i].activeKeyPic;
        }
    }


    /// <summary>
    /// Set a specific RawImage to a given texture
    /// </summary>
    /// <param name="i"> spot in the List </param>
    /// <param name="pic">Texture to change the RawImage to</param>
    public void gotIngredient(int i, Texture2D uIPic, Texture2D keyPic)
    {
        recipeSlots[i].texture = uIPic;
        keySlots[i].texture=keyPic;
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
