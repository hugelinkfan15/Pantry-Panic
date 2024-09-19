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
        StartCoroutine(makeOrder());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator makeOrder()
    {
        yield return new WaitForSeconds(3.0f);

        while(gameStart /*&& recipeDone*/ && !gameOver)
        {
            orders.Add(rC.makeRecipe());
            //recipeDone = false;

            yield return new WaitForSeconds(3.0f);
        }
    }
}
