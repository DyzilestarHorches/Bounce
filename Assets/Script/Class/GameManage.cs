using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    [SerializeField] private SO_GameManagerData gameManagerData;
    public SO_BallData ballData;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ballData.jumpRange += 10;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            ballData.jumpRange -= 10;
        }
    }
}
