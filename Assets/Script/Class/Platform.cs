using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public SO_PlatformData platformData;
    public bool unpredictableExist = false;

    // Start is called before the first frame update
    void Start()
    {
        InitRec();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
        ChangePosition();
        UnpredictableMovement();
    }

    void InitRec()
    {
        Vector2 _midpoint, _size;
        _midpoint = new Vector2(transform.position.x, transform.position.y + 6);
        _size = new Vector2(14, 6);
        platformData.pointZone = new Rectangle(_midpoint, _size);
    }
    void UpdateData()
    {
        platformData.pointZone.midPoint.y = transform.position.y + 6;    platformData.pointZone.midPoint.x = transform.position.x;
        platformData.position = transform.position;
    }

    void ChangePosition()
    {
        if (transform.position.y < platformData.despawn)
        {
            transform.position = new Vector3(Random.Range(platformData.leftLimit, platformData.rightLimit), platformData.spawn, 0f);
            UnpredictableExist();
        }
        UpdateData();
    }

    void MovePlatform()
    {
        transform.position -= new Vector3(0f, platformData.moveSpeed, 0f) * Time.deltaTime;     
    }    
    
    void UnpredictableMovement()
    {
        if (transform.position.y < 25 && unpredictableExist)    //Should we randomize this number
        {
            StartCoroutine(UnpredictableMoving());
            unpredictableExist = false;
        }
    }

    IEnumerator UnpredictableMoving()
    {
        int delay = Random.Range(4, 7);     //or recalculate this number
        yield return new WaitForSecondsRealtime(delay);
        
        Vector3 direction = new Vector3(Random.Range(-16f, 16f), 0f, 0f);       //range -> no body wants it to move 1 unit -> different random range
        Vector3 startPosition = transform.position;
        Vector3 targetPosition = startPosition + direction;
        
        float speed = Random.Range(0.1f, 0.2f);
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
        //Debug.Log("count" + count);
        if (count > 5f)
        {
            unpredictableExist = true;
        } 
        else
        {
            unpredictableExist = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(new Vector2(-100, platformData.despawn), new Vector2(100, platformData.despawn));
        Gizmos.DrawLine(new Vector2(-100, platformData.spawn), new Vector2(100, platformData.spawn));
        Gizmos.DrawLine(new Vector2(transform.position.x - 14, transform.position.y + 12), new Vector2(transform.position.x + 14, transform.position.y + 12));
    }
}

//Change platformData from 1 universal one to seperate unique SO for each platform -> good for proccess relative task between platforms 
//and other objects from a controlling class. For ex: scoring system
