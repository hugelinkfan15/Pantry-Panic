using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderTrigger : MonoBehaviour
{
    public bool inSweetSpot;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("working enter");
        if(other.gameObject.CompareTag("Slider"))
        {
            Debug.Log("working bool");
            inSweetSpot = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("working exit");
        if(other.gameObject.CompareTag("Slider"))
        {
            Debug.Log("working bool");
            inSweetSpot = false;
        }
    }
}
