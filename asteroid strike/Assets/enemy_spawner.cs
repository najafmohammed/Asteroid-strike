﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    float randx;
    Vector2 whereToStart;
    public float spawnRate=2f;
    public float nextSpawn = 0.0f; 
    
    void Update()
    {
        
        if (Time.time > nextSpawn)
        {
            nextSpawn=Time.time + spawnRate;
            randx=player.transform.position.x;
            whereToStart = new Vector2(randx,transform.position.y);
            Instantiate (enemy,whereToStart,Quaternion.identity);
            
        }
    }
    

}
