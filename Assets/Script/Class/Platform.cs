using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public SO_PlatformData size;

    [SerializeField]
    private float moveSpeed = 2f;

    [SerializeField]
    private float despawn = -30f;

    [SerializeField]
    private float spawn = 40f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
        ChangePosition();
        UnpredictedMovement();
    }

    void ChangePosition()
    {
        if (transform.position.y < despawn)
        {
            transform.position = new Vector3(Random.Range(-35f, 35f), spawn, 0f);
        }
    }

    void MovePlatform()
    {
            transform.position -= new Vector3(0f, moveSpeed, 0f) * Time.deltaTime;
    }

    IEnumerator UnpredictedMovement()
    {
        float delay = Random.Range(0f, 2f);

        for ()
        private int direction = Random.Range(0, 1);
        
    yeild return null;
    }
}
