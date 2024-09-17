using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RecipeCreator : MonoBehaviour
{
    public List<Ingredient> validIngreds;
    public float waitTime;

    private Dictionary<string,int> ingredientRank = new Dictionary<string, int>
    {
        {"Bread",1 },
        {"Meat", 2 },
        {"Cheese",3 },
        {"Topping", 4 }
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    List<Ingredient> makeRecipe()
    {
        List<Ingredient> recipe = new List<Ingredient>{ validIngreds[0] };
        int numIngred = Random.Range(1, validIngreds.Count-2);

        return recipe;

    }

    List<Ingredient> sortRecipe(ref List<Ingredient> recipe)
    {
        return recipe;
    }
}
