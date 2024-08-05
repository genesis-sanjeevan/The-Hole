using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour

{
    public GameObject level_Option;

    public void start_play()
    {
        level_Option.SetActive(true);
    }

    public void Home_screen()
    {
        level_Option.SetActive(false);
    }

    public void load_Level(int level)
    {
        SceneManager.LoadSceneAsync(level);
    }
}






