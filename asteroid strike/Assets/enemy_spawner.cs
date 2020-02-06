using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject enemy;
    float randx;
    Vector2 whereToStart;
    public float spawnRate=2f;
    float nextSpawn = 0.0f; 
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
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
