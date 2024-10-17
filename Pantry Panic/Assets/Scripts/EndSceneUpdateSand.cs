using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneUpdateSand : MonoBehaviour
{
    public Text counter;

    public SandwichTracker sT;
    public SceneTracker tracker;

    // Start is called before the first frame update
    void Start()
    {
        counter.text = sT.sandwhichsMade.ToString();
        sT.ClearTotal();
        tracker.Clear();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
