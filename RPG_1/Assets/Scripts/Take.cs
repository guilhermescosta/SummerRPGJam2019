using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Item item;
    public bool isOver;
    public bool interactable;

    public Inventory _inventory;

    public Texture2D takeIcon;

    private void OnMouseOver()
    {
        if (interactable)
        {
            if (gameObject.CompareTag("item"))
            {
                // Debug.Log(gameObject.name);
                isOver = true;
            }

           
        }
    }

    private void OnMouseExit()
    {
       
            isOver = false;
        
    }

    private void Update()
    {
        if (isOver && Input.GetMouseButtonDown(0)) {
            _inventory.Add(item);
            
            Destroy(gameObject);

        }

        if (interactable == false) {
            isOver = false;
        }
    }

   

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject);
        if (other.CompareTag("Player")) {
            interactable = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        interactable = false;
    }


}
