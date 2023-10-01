using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public float speed;
    public float hight;
    public Rigidbody2D rig;
    Vector2 move;
    public Collect collect;
    int Rose_Quartz;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
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
        if (Input.GetButtonDown("Fire2") && rig.position.y < -0.67)
        {
            speed = 5;
        }
        if (collect.BallScore == Rose_Quartz + 1)
        {
            speed = 2;
            Rose_Quartz++;
        }
    }

}
