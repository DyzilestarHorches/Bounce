using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ob : MonoBehaviour
{
    public float damage;
    float damegeRate = 0.5f;
    public float pushBackForce;
    float nextDamage;
    // Start is called before the first frame update
    void Start()
    {
        nextDamage = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "ball" && nextDamage < Time.time)
        {
            BallHealth theBallHealth = other.gameObject.GetComponent<BallHealth>();
            theBallHealth.addDamge(damage);
            nextDamage = damegeRate + Time.time;

            //pushBackForce(other.transform);
        }
    }

    void pushBack(Transform pushedObject)
    {
        Vector2 pushDirection = new Vector2(0, (pushedObject.position.y - transform.position.y)).normalized;
        pushDirection *= pushBackForce;
        Rigidbody2D pushRb = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        pushRb.velocity = Vector2.zero;
        pushRb.AddForce(pushDirection, ForceMode2D.Impulse);
    }
}
