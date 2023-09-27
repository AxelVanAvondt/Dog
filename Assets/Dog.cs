using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public float speed;
    public float hight;
    public Rigidbody2D rig;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && rig.position.y < -0.67)
        {
            rig.velocity = new Vector2(0, hight);
        }
        move = new Vector2 (Input.GetAxisRaw("Horizontal"), 0);
        transform.Translate(move *  speed * Time.deltaTime);
    }

}
