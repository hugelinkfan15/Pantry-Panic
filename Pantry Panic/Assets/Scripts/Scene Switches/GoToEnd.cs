using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToEnd : MonoBehaviour
{
    public Timer timer;

    public SceneReference scene;

    // Update is called once per frame
    void Update()
    {
        if(timer.timerDone)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
