using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    public void second_level()
    {
        int currentSceneID = SceneManager.GetActiveScene().buildIndex;
        int levelID = currentSceneID + 1;  
        SceneManager.LoadScene(levelID);
        next_level();
    }

    public void next_level()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("reachedIndex"))
        {
            PlayerPrefs.SetInt("reachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("unlocked level", PlayerPrefs.GetInt("Unlocked level", 1 )+ 1);
            PlayerPrefs.Save();
               
        }
    }
    

}
