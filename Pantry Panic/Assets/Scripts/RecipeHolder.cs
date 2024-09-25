using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeHolder : MonoBehaviour
{
    public RecipeCreator rC;
    public List< List<Ingredient>> orders;
    public int maxOrders;
    public bool gameStart;
    public bool gameOver;
    public bool recipeDone;

    // Start is called before the first frame update
    void Start()
    {
        rC = GameObject.FindGameObjectWithTag("Recipe").GetComponent<RecipeCreator>();
        orders = new List<List<Ingredient>>();
        recipeDone = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(recipeDone)
        {
            recipeDone=false;
            orders.Add(rC.makeRecipe());
        }
    }
}
