using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneReset : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(2);
        }
       if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(1);
        }
    }
}
