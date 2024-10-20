using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeHolder : MonoBehaviour
{
    [Header("Need Scripts")]
    public RecipeCreator rC;
    public List< List<Ingredient>> orders;

    [Header("Ints")]
    public int maxOrders;

    [Header("Booleans")]
    public bool gameStart;
    public bool gameOver;
    public bool recipeDone;

    [Header("")]
    public Texture2D correct;
    public RawImage wrong;

    public GameObject fSandwhich;

    [Header("SFX")]
    public AudioClip correctSFX;
    public AudioClip wrongSFX;

    private int ingredientNum;
    private List<Ingredient> currentSandwhich;
    private List<GameObject> finishedSandwhich;

    public SandwichTracker sT;

    public float cooldown;
    private float cdTimer;


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
        cdTimer += Time.deltaTime;
        if(recipeDone)
        {
            recipeDone=false;
            orders.Add(rC.makeRecipe());
            currentSandwhich = orders[0];
            rC.updateUI(currentSandwhich);
            ingredientNum = 0;
        }
        if (Input.GetKeyDown(currentSandwhich[ingredientNum].getKeyCode()) && (cdTimer > cooldown) && !PauseMenu.isPaused)
        {
            currentSandwhich[ingredientNum].makeIngredient();
            SoundFXManager.instance.PlaySoundFXCLip(correctSFX, gameObject.transform, 1.0f);
            rC.gotIngredient(ingredientNum, correct, currentSandwhich[ingredientNum].unactiveKeyPic);
            ingredientNum++;
        }
        else if((Input.anyKeyDown && !Input.GetKeyDown(KeyCode.P)) && (cdTimer>cooldown) && !PauseMenu.isPaused)
        {
            
            cdTimer = 0.0f;
            wrong.gameObject.SetActive(true);
            makeAndThrow();
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
        sT.made();
        yield return new WaitForSeconds(0.8f);


        for (int i = fSandwhich.transform.childCount-1; i>=0 ; i--)
        {
            Destroy(fSandwhich.transform.GetChild(i).gameObject);
        }

        orders.Clear();
        recipeDone = true;
    }

    private void makeAndThrow()
    {
        for(int i = 0;i<rC.validIngreds.Count;i++)
        {
            if (Input.GetKeyDown(rC.validIngreds[i].getKeyCode()))
            {
                rC.validIngreds[i].makeIngredient();
                GameObject temp = fSandwhich.transform.GetChild(fSandwhich.transform.childCount - 1).gameObject;
                temp.GetComponent<Rigidbody>().AddForce(Vector3.right *50,ForceMode.Impulse);
                Destroy(temp, 1.0f);
            }
        }
    }
}
