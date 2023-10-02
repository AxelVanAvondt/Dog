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
    float Ruby_Sapphire;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Ruby_Sapphire = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && rig.position.y < -0.67)
        {
            rig.velocity = new Vector2(0, hight);
        }
        move = new Vector2 (Ruby_Sapphire, 0);
        transform.Translate(move *  speed * Time.deltaTime);
        if(Ruby_Sapphire > 0 && transform.localScale.x > 0)
        {
            gameObject.transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        if (Ruby_Sapphire < 0 && transform.localScale.x < 0)
        {
            gameObject.transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
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
