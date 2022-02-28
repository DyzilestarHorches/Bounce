using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public CanvasGroup Main;// fmainmenu alpha
    public List<Transform> subMenus = new List<Transform>();//mainly used for motion in each submenu

    // Click play the MainScene
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    // click on OptionButton from mainMenu
    public void OpenOptionPanel()
    {
        this.gameObject.SetActive(false);
        subMenus[0].gameObject.SetActive(true);
        //motion 
        subMenus[0].localPosition = new Vector2(0, -20);
        subMenus[0].LeanMoveLocalY(0, 1).setEaseOutQuart();
        
    }
    // click on LeaderBoardButton from mainMenu
    public void OpenLeaderBoardPanel()
    {
        this.gameObject.SetActive(false);
        subMenus[1].gameObject.SetActive(true);
        //motion
        subMenus[1].localPosition = new Vector2(0, -20);
        subMenus[1].LeanMoveLocalY(0, 1).setEaseOutQuart();
    }
    // click on StoreButton from MainMenu
    public void OpenStorePanel()
    {
        this.gameObject.SetActive(false);
        subMenus[2].gameObject.SetActive(true);
        //motion
        subMenus[2].localPosition = new Vector2(0, -20);
        subMenus[2].LeanMoveLocalY(0, 1).setEaseOutQuart();
    }
    // Back to MainMenu
    public void BackButton()
    {   
        foreach( Transform subMenu in subMenus)
        {
            subMenu.LeanMoveLocalY(-20, 0.1f).setEaseInExpo();
            subMenu.gameObject.SetActive(false);
        }
        Main.alpha = 0;
        this.gameObject.SetActive(true);
        Main.LeanAlpha(1,0.5f); 
    }
}
