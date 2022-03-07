using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    [SerializeField] private SO_GameManagerData gameManagerData;
    public SO_BallData ballData;
    public SO_PlatformData[] platformDatas;

    private int platform_index;

    private void Awake()
    {
        platform_index = 0;
        gameManagerData.score = 0;
    }

    private void Update()
    {
        Scoring();
    }

    void Scoring()
    {
        if (platformDatas[(platform_index + 1) % 5].pointZone.insideCheck(ballData.position))
        {
            platform_index++;
            if (platform_index > 4) platform_index = 0;

            gameManagerData.score++;
        }
    }
}
