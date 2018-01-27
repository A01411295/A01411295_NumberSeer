using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{

    public void loadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void endGame()
    {
        Application.Quit();
    }
}
