using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public int BallScore;
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Ball"))
        {
            Destroy(collider2D.gameObject);
            BallScore++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        BallScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
