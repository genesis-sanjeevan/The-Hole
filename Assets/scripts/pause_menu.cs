using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class pause_menu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);

    }

    public void restart()
    {
        //string currentSceneName = SceneManager.GetActiveScene().name;
        int currentSceneID = SceneManager.GetActiveScene().buildIndex;
        print(currentSceneID);

        //SceneManager.LoadScene(currentSceneName);
        SceneManager.LoadScene(currentSceneID);
        Time.timeScale = 1f;
    }

    
}
