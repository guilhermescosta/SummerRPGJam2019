using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level;
    public string playerName;

    [Range(0,100)]
    public int strength;
    [Range(0, 100)]
    public int dexterity;
    [Range(0, 100)]
    public int intelligence;
    

    public int hp;
    public int mp;

    public int xp;


    public Animator _anim;
    // Start is called before the first frame update

  
        void Start()
    {
        //warrior
        level = 1;
        strength = 10;
        dexterity = 5;
        intelligence = 1;
        hp = 10;
        mp = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, 0, 0.05f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.02f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

    }

    public void Attack() {
        _anim.SetTrigger("Attack_Move");
    }
}
