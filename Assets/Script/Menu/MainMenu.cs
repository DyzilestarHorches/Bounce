using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionPanel;
    public GameObject LeaderBoardPanel;
    public GameObject StorePanel;
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
        OptionPanel.gameObject.SetActive(true);
    }
    // click on LeaderBoardButton from mainMenu
    public void OpenLeaderBoardPanel()
    {
        this.gameObject.SetActive(false);
        LeaderBoardPanel.gameObject.SetActive(true);
    }
    // click on StoreButton from MainMenu
    public void OpenStorePanel()
    {
        this.gameObject.SetActive(false);
        StorePanel.gameObject.SetActive(true);
    }
    // Back to MainMenu
    public void BackButton()
    {
        this.gameObject.SetActive(true);
        OptionPanel.gameObject.SetActive(false);
        LeaderBoardPanel.gameObject.SetActive(false);
        StorePanel.gameObject.SetActive(false);
    }
}
