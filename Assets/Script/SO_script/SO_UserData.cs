using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new MyUserData", menuName = "MyUserData", order = 56)]
public class SO_UserData : ScriptableObject
{
    public string userName;
    public int highScore;
}
