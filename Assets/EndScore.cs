using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScore : MonoBehaviour
{
    public TMP_Text End;
    int Tikki;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Plagg();
    }
    void Plagg()
    {
        Tikki = PlayerPrefs.GetInt("shs", 0);
        End.text = "HighScore: " + Tikki.ToString();
    }
}
