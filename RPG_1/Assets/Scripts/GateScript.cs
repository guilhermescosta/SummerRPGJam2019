using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public GameObject Gate;
    public bool gateOpen;
    public float timer;
    public Animator anim;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }
    
    void OnTriggerStay (Collider col)
    {
        if (Input.GetKey(KeyCode.E))
        {
            gateOpen = true;
            Gate.transform.Translate(Vector3.up * Time.deltaTime * 3);

            Debug.Log("Door Open");
            
        }

        if(Gate.transform.position.y > 7)
        {
            gateOpen = false;
            Gate.transform.Translate(Vector3.down * Time.deltaTime * 3);
        }

        
    }
}
