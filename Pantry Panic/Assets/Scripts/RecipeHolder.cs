using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeHolder : MonoBehaviour
{
    public RecipeCreator rC;
    public List< List<Ingredient>> orders;
    public int maxOrders;
    public bool gameStart;
    public bool gameOver;
    public bool recipeDone;
    public Texture2D correct;

    private int ingredientNum;
    private List<Ingredient> currentSandwhich;
    private List<GameObject> makingSandwhich;

    // Start is called before the first frame update
    void Start()
    {
        rC = GameObject.FindGameObjectWithTag("Recipe").GetComponent<RecipeCreator>();
        orders = new List<List<Ingredient>>();
        recipeDone = true;
        currentSandwhich = new List<Ingredient>();
    }

    // Update is called once per frame
    void Update()
    {
        if(recipeDone)
        {
            recipeDone=false;
            orders.Add(rC.makeRecipe());
            currentSandwhich = orders[0];
            rC.updateUI(currentSandwhich);
            ingredientNum = 0;
        }
        if (Input.GetKeyDown(currentSandwhich[ingredientNum].getKeyCode()))
        {
            currentSandwhich[ingredientNum].makeIngredient();
            ingredientNum++;
        }
        if(ingredientNum == currentSandwhich.Count)
        {
            recipeDone = true;
            orders.Clear();
        }
    }
}
