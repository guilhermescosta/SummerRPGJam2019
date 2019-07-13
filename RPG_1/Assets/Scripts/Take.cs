using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    public Item item;
    public bool isOver;
    public Inventory _inventory;

    private void OnMouseOver()
    {
        
        if (gameObject.CompareTag("item")){
           // Debug.Log(gameObject.name);
            isOver = true;
        }
    }

    private void OnMouseExit()
    {
        isOver = true;
    }

    private void Update()
    {
        if (isOver && Input.GetMouseButtonDown(0)) {
            _inventory.Add(item);
            
            Destroy(gameObject);

        }   
    }


}
