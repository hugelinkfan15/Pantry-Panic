using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAway : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf)
        {
            StartCoroutine(GoAway());
        }
    }

    IEnumerator GoAway()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}
