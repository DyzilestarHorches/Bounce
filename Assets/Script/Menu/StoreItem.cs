using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new storeItem", menuName = "item" )]
public class StoreItem : ScriptableObject
{
    // Artwork for item.
    public Sprite artWork;
    public string status;
}
