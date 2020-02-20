using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_random : MonoBehaviour
{
  

    public GameObject enemy;
    float randx;
    Vector2 whereToStart;
    public float spawnRate=2f;
    public float nextSpawn = 0.0f; 
     void Update()
    {
         
        if (Time.time > nextSpawn)
        {
            nextSpawn=Time.time + spawnRate;
            randx=Random.Range(2.63f,-2.63f);
            whereToStart = new Vector2(randx,transform.position.y);
            Instantiate (enemy,whereToStart,Quaternion.identity);
            
        }
    }
}
