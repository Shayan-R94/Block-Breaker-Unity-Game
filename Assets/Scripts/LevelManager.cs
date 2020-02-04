using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        Brick.breakableCount = 0;
        Ball.hasStarted = false;
        GameControl.health = 5;
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("I want to Quit!");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        Brick.breakableCount = 0;
        Ball.hasStarted = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BrickDestroyed()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
