using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float FireForce;
    public GameObject Ball;
    public Transform Firepoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }
    public void Fire()
    {
        GameObject _Ball = Instantiate(Ball, Firepoint.position, Firepoint.rotation);
        _Ball.GetComponent<Rigidbody2D>().velocity = RandomVector(0f, 1f) * FireForce;
    }
    public Vector2 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        return new Vector2(x, y);
    }
}
