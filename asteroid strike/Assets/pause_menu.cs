using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pause_menu : MonoBehaviour
{
   public static bool GameIsPaused = false;
   public GameObject pauseMenuUI;
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(!pauseMenuUI.activeSelf);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Main_Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
