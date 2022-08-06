using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManage : MonoBehaviour
{
    [SerializeField] private SO_GameManagerData gameManagerData;
    public SO_BallData ballData;
    public SO_UserData userData;
    public SO_MyState startingState;
    public SO_PlatformData[] platformDatas;
    
    private int platform_index;

    
    private void Start()
    {
        Debug.Log("restart");
        Time.timeScale = 2;
        platform_index = 0;
        gameManagerData.gameSpeed = 2;
        gameManagerData.score = 0;
        gameManagerData.gameState = startingState;
        Debug.Log(gameManagerData.gameState.stateName);
    }
    private void Update()
    {
        Scoring();
        CheckEndGame();
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
    
    public void Pause()
    {
        gameManagerData.gameSpeed = 0;
        ballData.isPause = true;
    }

    public void Resume()
    {
        gameManagerData.gameSpeed = 2;
        ballData.isPause = false;
    }

    public void EndGame()
    {
        
        gameManagerData.gameSpeed = 0;
        ballData.isPause = true;
        gameManagerData.lastScore = gameManagerData.score;
        if (gameManagerData.lastScore > userData.highScore)
        {
            userData.highScore = gameManagerData.lastScore;
        }
        gameManagerData.score = 0;
    }

    void CheckEndGame()
    {
        if (platformDatas[0].despawn > ballData.position.y && gameManagerData.gameState.stateName != "over")
        {
            Debug.Log("End");
            gameManagerData.gameState = gameManagerData.gameState.ChangeState("over");
        }
    }

    
}
