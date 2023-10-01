using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public Collect collect;
    public TMP_Text point;
    public int hs;
    public int shs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(collect.BallScore > hs)
        {
            hs = collect.BallScore;
            point.text = "Highscore: " + hs.ToString();
            PlayerPrefs.SetInt("shs", hs);
            PlayerPrefs.Save();
        }
    }
}
