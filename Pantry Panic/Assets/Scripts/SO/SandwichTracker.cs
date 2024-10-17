using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MenuSettings",menuName = "SO/Data/Trackers/SandwhichTracker",order = 1)]
public class SandwichTracker : ScriptableObject
{
    public int sandwhichsMade;
    public int totalSandwiches;

    public void made()
    {
        sandwhichsMade++;
        totalSandwiches++;
    }

    public void ClearDaily()
    {
        sandwhichsMade = 0;
    }

    public void ClearTotal()
    {
        totalSandwiches = 0;
    }
}
