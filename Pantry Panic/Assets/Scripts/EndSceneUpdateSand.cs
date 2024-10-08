using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneUpdateSand : MonoBehaviour
{
    public Text counter;

    public SandwichTracker sT;

    // Start is called before the first frame update
    void Start()
    {
        counter.text = sT.sandwhichsMade.ToString();
        sT.Clear();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
