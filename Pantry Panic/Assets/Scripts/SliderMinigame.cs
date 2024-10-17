using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SliderMinigame : MonoBehaviour
{
    public Slider gameSlider;

    public float sweetSpot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void newSpot()
    {
        sweetSpot = Random.Range(0, 9);
    }
}
