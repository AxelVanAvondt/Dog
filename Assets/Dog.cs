using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public float speed;
    public float jump;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            move = new Vector2(0, Input.GetAxisRaw("Vertical"));
            transform.Translate(move * jump * Time.deltaTime);
        }
        move = new Vector2 (Input.GetAxisRaw("Horizontal"), 0);
        transform.Translate(move *  speed * Time.deltaTime);
    }

}
