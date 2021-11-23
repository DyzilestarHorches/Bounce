using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new PlatformData", menuName = "PlatformData", order = 54)]
public class SO_PlatformData : ScriptableObject
{
    public Vector2 size;
    public Sprite image;
    public float spawn;
    public float despawn;
    public float leftLimit;
    public float rightLimit;
    public float moveSpeed;
}
