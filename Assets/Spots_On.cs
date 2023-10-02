using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spots_On : MonoBehaviour
{
    public TMP_Text HAAAA;
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
        Tikki = PlayerPrefs.GetInt("Claws_Out", 0);
        HAAAA.text = "Score: " + Tikki.ToString();
    }
}
