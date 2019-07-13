using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int space = 20;

    #region Singleton
    public static Inventory instance;
   

    private void Awake()
    {
        if (instance != null) {
            Debug.Log("duplicado");
        }
        instance = this;
    }

    #endregion

    public List<Item> items = new List<Item>();

    public void Add(Item _item) {
        if (items.Count >= space) {
            Debug.Log("inventory full");
        }
        else
         items.Add(_item);
    }

    public void Remove(Item _item) {
        items.Remove(_item);

    }


}
