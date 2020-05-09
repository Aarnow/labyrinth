using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Allows access to the scenes

public class UIScript : MonoBehaviour
{
    public void ExitGame()
    {
        #if UNITY_EDITOR //Syntax differently compile
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Continue()
    {
        int levelToLoad = PlayerPrefs.GetInt("LevelToLoad");

        if (levelToLoad > 1)
        {
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }
   
}
