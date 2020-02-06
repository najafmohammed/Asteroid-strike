using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class character_controller : MonoBehaviour
{
    public GameObject gameover;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Time.timeScale = 0f;
        gameover.SetActive(true);
    } 
        
}

