using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHealth : MonoBehaviour
{
    public float maxHealth;
    float currentHealth;

    public GameObject TakeDamegeEffect;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamge(float damege)
    {
        if (damege > 0)
            currentHealth -= damege;
        if (currentHealth <= 0)
            makeDead();
    }

    void makeDead()
    {
        Instantiate(TakeDamegeEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
