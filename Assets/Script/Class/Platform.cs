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

    public bool unpredictableExist = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
        ChangePosition();
        UnpredictableMovement();
    }

    void ChangePosition()
    {
        if (transform.position.y < despawn)
        {
            transform.position = new Vector3(Random.Range(-35f, 35f), spawn, 0f);
            UnpredictableExist();
        }
    }

    void MovePlatform()
    {
            transform.position -= new Vector3(0f, moveSpeed, 0f) * Time.deltaTime;
    }    
    
    void UnpredictableMovement()
    {
        if (transform.position.y < 25 && unpredictableExist)
        {
            StartCoroutine(UnpredictableMoving());
            unpredictableExist = false;
        }
    }

    IEnumerator UnpredictableMoving()
    {
        int delay = Random.Range(4, 7);
        yield return new WaitForSecondsRealtime(delay);
        
        Vector3 direction = new Vector3(Random.Range(2f, 4f), 0f, 0f);
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = startPosition + direction;
        
        float speed = Random.Range(0.5f, 1f);
        float time = 0f;

        while(transform.position != targetPosition)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, (time / Vector3.Distance(startPosition, targetPosition)) * speed);
            time += Time.deltaTime;
        }
        yield return null;
    }

    void UnpredictableExist()
    {
        float count = Random.Range(0f, 10f);
        Debug.Log("count" + count);
        if (count > 5f)
        {
            unpredictableExist = true;
        } 
        else
        {
            unpredictableExist = false;
        }
    }
}
