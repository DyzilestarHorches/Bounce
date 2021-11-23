using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DisplayItem : MonoBehaviour
{
    public StoreItem Item;

    public Image ArtWork;
    public TextMeshProUGUI nameText;
    // Start is called before the first frame update
    void Start()
    {
        ArtWork.sprite = Item.artWork;
        nameText.text = Item.status;
    }

     
}
