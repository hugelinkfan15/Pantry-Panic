using UnityEngine;
using UnityEngine.SceneManagement; // For scene management

public class RestartGame : MonoBehaviour
{
    void Update()
    {
        // Check if the player presses the "R" key
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGameFunction();
        }
    }

    void RestartGameFunction()
    {
        // Load the tutorial scene (build index 0)
        SceneManager.LoadScene(0);
    }
}
