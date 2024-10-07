using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwhichTracker : MonoBehaviour
{
    private static int sandwhiches = 0;

    public void made()
    {
        sandwhiches++;
    }

    public int getSandwhiches()
    {
        int temp = sandwhiches;
        sandwhiches = 0;
        return temp;
    }
}
