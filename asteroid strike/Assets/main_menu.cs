using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Main_game");
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void helpGame()
    {
        SceneManager.LoadScene("Help");
    }
    public void BackToMainMenu(){
        SceneManager.LoadScene("Main_Menu");
    }
}
