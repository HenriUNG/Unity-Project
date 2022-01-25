using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenuPause : MonoBehaviour
{
    public static bool MenuPause = false;
    public GameObject Menu;

   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (MenuPause)
            {
                Reprendre();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Reprendre()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        MenuPause = false;
    }

    void Pause()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
        MenuPause = true;
    }

    public void RetourMenu()
    {
        SceneManager.LoadScene(0);
        Menu.SetActive(false);
        Time.timeScale = 1f;
        MenuPause = false;
    }

    public void Quitter()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}

