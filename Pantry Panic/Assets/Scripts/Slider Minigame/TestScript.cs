using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public RawImage wrong;
    public RawImage correct;

    public SliderTrigger trigger;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(trigger.inSweetSpot)
            {
                correct.gameObject.SetActive(true);
            }
            else
            {
                wrong.gameObject.SetActive(true);
            }
        }
    }
}
