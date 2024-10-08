using UnityEngine;
using UnityEngine.SceneManagement; // For scene management

public class RestartGame : MonoBehaviour
{

    public SceneReference tutorial;
    public SceneReference kitchen;
    void Update()
    {
        // Check if the player presses the "R" key
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(kitchen);
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(tutorial);
        }
    }
}
