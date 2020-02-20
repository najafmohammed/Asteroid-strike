using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class character_controller : MonoBehaviour
{
    public GameObject gameover;
    public GameObject shieled_ui;
    public GameObject enemy;
    public static int immunity=0;

    private void OnTriggerExit2D(Collider2D col) 
    {   
        if(col.gameObject.tag=="point_1000"){
            score_script.scoreValue+=1000;
            }
        if(col.gameObject.tag=="point_2500"){  
            score_script.scoreValue+=2500;
            }
        if(col.gameObject.tag=="immunity_powerup"){  
            immunity=2;
            shieled_ui.SetActive(true);
        }
             
    }
    
    private void OnTriggerEnter2D(Collider2D col1) {
        
        if(col1.gameObject.tag=="enemy"){
            if(immunity<1){
            Time.timeScale = 0f;
            gameover.SetActive(true);
            }
            else
            {
                immunity-=1;
                shieled_ui.SetActive(false);
            }
        }
        
    }
    
}

