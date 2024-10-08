using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwhichTracker : MonoBehaviour
{
    private static int sandwhiches;

    public void made()
    {
        sandwhiches++;
        Debug.Log("Sandwhich");
        Debug.Log(sandwhiches);

    }

    public int getSandwhiches()
    {
        int temp = sandwhiches;
        sandwhiches = 0;
        return temp;
    }
}
