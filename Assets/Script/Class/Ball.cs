using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public SO_BallData ballData;

    Rigidbody2D rigid;

    bool grounded;


    // Start is called before the first frame update
    private void Awake()
    {
        ballData.position = transform.position;
    }
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();
        ballData.isPause = false;
        ballData.speed = 30f;
        ballData.jumpRange = 90f;
        rigid.gravityScale = 12;

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        controlBallActive();
    }

    void controlBallActive()
    {
        if (ballData.isPause)
        {
            ballData.jumpRange = 0;
            ballData.speed = 0;
            rigid.velocity = new Vector2(0, 0);
            rigid.gravityScale = 0;
        }
        else
        {
            ballData.speed = 30f;
            ballData.jumpRange = 90f;
            rigid.gravityScale = 12;
        }
    }

    private void Move()
    {
        Vector2 movement = new Vector2(0, rigid.velocity.y);
        if (Input.GetKey(KeyCode.A))
            movement.x = -1 * ballData.speed;
        if (Input.GetKey(KeyCode.D))
            movement.x = 1 * ballData.speed;
        rigid.velocity = movement;

        ballData.position = transform.position;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
                //Debug.Log("it's here!");
                rigid.velocity = new Vector2(rigid.velocity.x, ballData.jumpRange);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }


}


