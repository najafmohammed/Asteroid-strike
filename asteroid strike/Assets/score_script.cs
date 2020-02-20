using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_script : MonoBehaviour
{
    public static int scoreValue=0;
    public GameObject spawner_2;
    public GameObject point_1000;
    public GameObject point_2500;
    public GameObject immunity;
    public GameObject spawner_3;
 
    Text score;
    
    void Start()
    {
        score =GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text="Score:"+scoreValue;
        if (scoreValue>2500 )
        {
            spawner_2.SetActive(true);
        }
        if (scoreValue>500 )
        {
            point_1000.SetActive(true);
        }
        if (scoreValue>5500 )
        {
            point_2500.SetActive(true);
        }
        if (scoreValue>10500 )
        {
            immunity.SetActive(true);
        }
        if (scoreValue>25500 )
        {
            spawner_3.SetActive(true);
        }
    }
     
}
