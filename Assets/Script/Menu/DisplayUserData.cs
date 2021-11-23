using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayUserData : MonoBehaviour
{
    public User user;
    public TextMeshProUGUI nameText;// use TextMeshProUGUI (belong to TMPro library) instead of TEXT
    public TextMeshProUGUI AchievementText ;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = user.name ;
        scoreText.text = user.score.ToString() + " m";// "score = 100" => "100 m"
        AchievementText.text = user.achievements ;
  
        user.print();
    }

}
