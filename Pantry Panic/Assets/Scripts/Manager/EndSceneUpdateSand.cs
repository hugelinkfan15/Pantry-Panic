using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneUpdateSand : MonoBehaviour
{
    public Text counter;

    private SandwhichTracker sT;
    // Start is called before the first frame update
    void Start()
    {
        sT = gameObject.GetComponent<SandwhichTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = sT.getSandwhiches().ToString();
    }
}
