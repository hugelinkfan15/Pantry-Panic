using System;
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
    
    public GameObject fSandwhich;

    public RawImage wrong;

    //public SoundFXManager sFX;

    public AudioClip correctSFX;
    public AudioClip wrongSFX;

    private int ingredientNum;
    private List<Ingredient> currentSandwhich;
    private List<GameObject> finishedSandwhich;

    // Start is called before the first frame update
    void Start()
    {
        rC = GameObject.FindGameObjectWithTag("Recipe").GetComponent<RecipeCreator>();
        orders = new List<List<Ingredient>>();
        recipeDone = true;
        currentSandwhich = new List<Ingredient>();
        finishedSandwhich = new List<GameObject>();
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
            //SoundFXManager.instance.PlaySoundFXCLip(correctSFX, gameObject.transform, 1.0f);
            rC.gotIngredient(ingredientNum, correct);
            ingredientNum++;
        }
        else if(Input.anyKeyDown)
        {
            wrong.gameObject.SetActive(true);
            SoundFXManager.instance.PlaySoundFXCLip(wrongSFX, gameObject.transform, 1.0f);
        }
        if(ingredientNum == currentSandwhich.Count)
        {
            StartCoroutine(NextSandwhich());
        }
    }


    /// <summary>
    /// After a set pause, will delete the current children of fSandwhich, and will allow another recipe to be made in Update()
    /// </summary>
    /// <returns></returns>
    IEnumerator NextSandwhich()
    {
        yield return new WaitForSeconds(0.8f);


        for (int i = fSandwhich.transform.childCount-1; i>=0 ; i--)
        {
            Destroy(fSandwhich.transform.GetChild(i).gameObject);
        }

        orders.Clear();
        recipeDone = true;
    }
}
