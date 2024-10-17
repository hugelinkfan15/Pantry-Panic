using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToEnd : MonoBehaviour
{
    public List<SceneReference> scenes;
    public Timer timer;
    public SceneTracker tracker;

    // Update is called once per frame
    void Update()
    {
        if(timer.timerDone)
        {
            tracker.increaseScene();
            SceneManager.LoadScene(scenes[tracker.index- 1]);
        }
    }
}
