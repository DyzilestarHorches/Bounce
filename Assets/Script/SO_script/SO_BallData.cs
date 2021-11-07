using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="new BallData", menuName ="BallData", order = 51)]
public class SO_BallData : ScriptableObject
{
    public float speed;
    public float jumpRange;
    public int health;
    public Sprite image;
}
