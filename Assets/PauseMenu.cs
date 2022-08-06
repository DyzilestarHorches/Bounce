using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Transform subMenu;
    public Transform OptionMenu;
    public CanvasGroup BlurBlank;
    public CanvasGroup Button;

    //scoring illustation
    public SO_GameManagerData gameData;
    public TMP_Text scoreIllu;

    public void Start()
    {
        this.gameObject.SetActive(false);
        OptionMenu.gameObject.SetActive(false);
    }

    public void OpenSubMenuEndGame()
    {
        BlurBlank.alpha = 0;
        BlurBlank.LeanAlpha(1, 1f);
        this.gameObject.SetActive(true);
        //hide pause button
        Button.LeanAlpha(0, 1f);
        //motion
        subMenu.localPosition = new Vector2(0, -Screen.height);
        subMenu.LeanMoveLocalY(-80, 0.8f).setEaseOutQuart();

        //scoring illustarion
        scoreIllu.text = gameData.lastScore.ToString();
    }
    public void OpenSubMenu()
    {
        BlurBlank.alpha = 0;
        BlurBlank.LeanAlpha(1, 1f);
        this.gameObject.SetActive(true);
        //hide pause button
        Button.LeanAlpha(0, 1f);
        //motion
        subMenu.localPosition = new Vector2(0, -Screen.height);
        subMenu.LeanMoveLocalY(-80, 0.8f).setEaseOutQuart();

        //scoring illustarion
        scoreIllu.text = gameData.score.ToString();

        //pause State trigger
        gameData.gameState = gameData.gameState.ChangeState("pause");
    }
    public void OpenOptionMenu()
    {
        subMenu.gameObject.SetActive(false);
        OptionMenu.gameObject.SetActive(true);
        OptionMenu.localPosition = new Vector2(0, -Screen.height);
        OptionMenu.LeanMoveLocalY(0, 1).setEaseOutQuart();
    }
    public void CloseOptionMenu()
    {
        OptionMenu.LeanMoveLocalY(-Screen.height, 0.8f).setEaseInQuart();
        subMenu.gameObject.SetActive(true);
        //motion again for submenu turnback
        subMenu.localPosition = new Vector2(0, -Screen.height);
        subMenu.LeanMoveLocalY(-80, 0.8f).setEaseOutQuart().delay = 0.5f;
    }  
    public void Resume()
    { 
        //hide back
        BlurBlank.LeanAlpha(0, 0.5f);
        //reveal button
        Button.LeanAlpha(1, 1f);
        subMenu.LeanMoveLocalY(-Screen.height, 0.8f).setEaseInQuart().setOnComplete(OnComplete);

        //restart game if over
        if (gameData.gameState.stateName == "over")
        {
            SceneManager.LoadScene("GameScene");
        } else
        //change game state
        gameData.gameState = gameData.gameState.ChangeState("active");

    }
    void OnComplete()
    {
        Debug.Log("?");
        this.gameObject.SetActive(false);
        
    }
   
}
