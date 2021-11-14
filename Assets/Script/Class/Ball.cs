using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public SO_BallData ballData;
    Rigidbody2D rigid;

    [SerializeField]
    private float jumpForce = 11f;


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
            rigid.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            Debug.Log("Jump");
        }
    }
}
