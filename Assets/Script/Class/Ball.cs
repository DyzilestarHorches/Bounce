using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public SO_BallData ballData;
    Rigidbody2D rigid;


    float speed = 10f;
    [SerializeField]public float jumpHeight;

    bool grounded;


    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();
        
        Time.timeScale = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Move2();
        Jump();
    }

    private void Move2()
    {
        Vector2 movement = new Vector2(0,0);
        if (Input.GetKey(KeyCode.A))
            movement.x = -1;
        if (Input.GetKey(KeyCode.D))
            movement.x = 1;
        rigid.velocity = movement * ballData.speed;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            {
                grounded = false;
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
