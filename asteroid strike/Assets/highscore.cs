using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    Text score;
    public static int scoreValue1;
    void Start()
    {
        score =GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue1=score_script.scoreValue;
        score.text=""+scoreValue1;
    }
}
