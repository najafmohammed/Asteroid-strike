using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
   public void RestartGame()
   {
       Time.timeScale = 1f;
       score_script.scoreValue=0;
       SceneManager.LoadScene("Main_game");
    }
}
