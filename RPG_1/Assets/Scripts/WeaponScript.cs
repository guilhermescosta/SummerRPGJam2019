using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public int weaponDamage = 3;
    



    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Enemy").GetComponent<Enemy>().Health = 50;
        GameObject.Find("Player").GetComponent<Player>().strength = 10;

        
     

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnColliderEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            
            Health -= strenght + weaponDamage; 
           
        }
        if (Health < 1) {
            Destroy(col.gameObject);
        }
    }
}
