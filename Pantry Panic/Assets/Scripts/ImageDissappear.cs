using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDissappear : MonoBehaviour
{

    public float waitSeconds;

    private float timePassed;
    // Start is called before the first frame update
    private void Start()
    {
        timePassed = 0.0f;
    }
    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf && (timePassed<waitSeconds))
        {
            timePassed += Time.deltaTime;
        }
        else
        {
            timePassed = 0.0f;
            gameObject.SetActive(false);
        }
    }
}
