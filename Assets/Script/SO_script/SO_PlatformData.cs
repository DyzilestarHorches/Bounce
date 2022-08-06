using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new PlatformData", menuName = "PlatformData", order = 54)]
public class SO_PlatformData : ScriptableObject
{
    //Scoring Rectangle
    public Rectangle pointZone;
    public Vector2 size, position;
    public Sprite image;
    public float spawn = 85;
    public float despawn = -85;
    public float leftLimit = -40;
    public float rightLimit = 40;
    public float moveSpeed = 5;
}

