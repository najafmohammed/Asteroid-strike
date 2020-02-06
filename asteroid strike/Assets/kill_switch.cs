using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (transform.position.y <=-4.0)
        Destroy(gameObject);
    }
    void FixedUpdate() {
      if(pause_menu.GameIsPaused == false)
        score_script.scoreValue +=1;  
    }
}
