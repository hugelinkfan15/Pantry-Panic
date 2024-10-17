using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MenuSettings",menuName = "SO/Data/Trackers/SceneTracker",order = 2)]
public class SceneTracker : ScriptableObject 
{
    public  int index;

    public void increaseScene()
    {
        index++;
    }

    public void Clear()
    {
        index = 0;
    }


}
