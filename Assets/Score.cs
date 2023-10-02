using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Collect collect;
    public TMP_Text point;
    int hs;
    int Claws_Out;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hs = collect.BallScore;
        point.text = "Score: " + hs.ToString();
        PlayerPrefs.SetInt("Claws_Out", hs);
        PlayerPrefs.Save();
    }
}
