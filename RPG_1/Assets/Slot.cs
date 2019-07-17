using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Item _item;
    public Image icon; 

    public void AddItem(Item newItem) {
        _item = newItem;
        icon.sprite = _item.icon;
        icon.enabled = true;
    }

    public void ClearSlot() {
        _item = null;
        icon.sprite = null;
        icon.enabled = false;

    }
}
