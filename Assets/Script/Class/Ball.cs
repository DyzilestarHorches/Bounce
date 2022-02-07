using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public SO_BallData ballData;

    Rigidbody2D rigid;

    float speed = 30f;  //in ballData
    [SerializeField] private float jumpHeight = 50f; //in ballData


    bool grounded;


    // Start is called before the first frame update
    void Start() 
    {
        rigid = this.GetComponent<Rigidbody2D>();

        Time.timeScale = 2; //try to get rid of it

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        Vector2 movement = new Vector2(0, rigid.velocity.y);
        if (Input.GetKey(KeyCode.A))
            movement.x = -1 * speed;
        if (Input.GetKey(KeyCode.D))
            movement.x = 1 * speed;
        rigid.velocity = movement;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
                //Debug.Log("it's here!");
                rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight);
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


