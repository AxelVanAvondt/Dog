using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    public Collect collect;
    public float seconds;
    int Pearl;
    // Start is called before the first frame update
    void Start()
    {
        seconds = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= 1 * Time.deltaTime;
        timer.text = seconds.ToString("0");
        if(collect.BallScore > Pearl)
        {
            seconds = 5f;
            Pearl++;
        }
        if(seconds <= 0)
        {
            SceneManager.LoadScene("Amethyst");
        }
    }
}
