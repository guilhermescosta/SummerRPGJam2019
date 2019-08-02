using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public int weaponDamage = 3;
    public float _strenght;




    // Start is called before the first frame update
    void Start()
    {

        _strenght = GameObject.Find("Player").GetComponent<Player>().strength;
    }

    private void OnCollisionEnter(Collision col)
    {
       
        
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("faz um garrote");
            if (col.gameObject.GetComponent<Enemy>().Health < 1)
            {
                Destroy(col.gameObject);
            }
            else
            {
                Debug.Log(col.gameObject.GetComponent<Enemy>().Health);
                col.gameObject.GetComponent<Enemy>().Health -=_strenght + weaponDamage;
            }

            

        }
        
       
        
    


    }

}
 
     
