using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewUser", menuName = "User")]
public class User : ScriptableObject
{
    public new string name;
    public int score;
    public string achievements;
    
    public void print()
    {
        Debug.Log(name + " got " + score + "m");    
    }
}
