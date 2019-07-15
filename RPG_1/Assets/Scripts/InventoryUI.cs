using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory _inventory;
    public Transform itemsParent;

    Slot[] slots;
    // Start is called before the first frame update
    void Start()
    {
        _inventory = Inventory.instance;

        slots = itemsParent.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateUI() {
      
        for (int i = 0; i < slots.Length; i++) {
            if (i < _inventory.items.Count)
            {
                slots[i].AddItem(_inventory.items[i]);
            }
            else {
                slots[i].ClearSlot();
            }

        }

    }


}
