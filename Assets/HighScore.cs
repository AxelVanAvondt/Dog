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
    int Tikki;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("shs"))
        {
            Plagg();
        }
        else
        {
            hs = collect.BallScore;
            point.text = "Highscore: " + hs.ToString();
            PlayerPrefs.SetInt("shs", hs);
            PlayerPrefs.Save();
        }
        if(Tikki < collect.BallScore)
        {
            hs = collect.BallScore;
            point.text = "Highscore: " + hs.ToString();
            PlayerPrefs.SetInt("shs", hs);
            PlayerPrefs.Save();
        }
    }
    void Plagg()
    {
        Tikki = PlayerPrefs.GetInt("shs", 0);
        point.text = "HighScore: " + Tikki.ToString();
    }
}
