using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MenuSettings",menuName = "SO/Data/Trackers/SandwhichTracker",order = 1)]
public class SandwichTracker : ScriptableObject
{
    public int sandwhichsMade;

    public void made()
    {
        sandwhichsMade++;
    }

    public void Clear()
    {
        sandwhichsMade = 0;
    }
}
