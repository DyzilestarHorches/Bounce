using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="new BallData", menuName ="BallData", order = 51)]
public class SO_BallData : ScriptableObject
{
    public Vector2 position;
    public float speed = 30f;
    public float jumpRange = 50f;
    public int health;
    public Sprite image;
    public bool isPause = false;
}
