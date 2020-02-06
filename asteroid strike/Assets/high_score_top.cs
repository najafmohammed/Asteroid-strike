using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class high_score_top : MonoBehaviour
{
    public Text highscore;
    int number;
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        number =score_script.scoreValue;
        if(number>PlayerPrefs.GetInt("HighScore",0))
        {
        PlayerPrefs.SetInt("HighScore",number);
        highscore.text=number.ToString();
        }
    }
}
