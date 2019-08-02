using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int level;
    public int xp;
    public int nextLv;

    public string playerName;

    [Range(0,100)]
    public int strength;
    [Range(0, 100)]
    public int dexterity;
    [Range(0, 100)]
    public int intelligence;
    
    public int hp;
    public int currentHp;
    public Image _hpBar;

    public int mp;
    public int currentMp;
    
    public bool attackMode;


    public Animator _anim;

    public bool isMove;


    // Start is called before the first frame update

  
        void Awake()
    {
        //warrior
        level = 1;
        strength = 10;
        dexterity = 5;
        intelligence = 1;
        hp = 10;
        currentHp = hp;
        mp = 1;

        attackMode = false;
        isMove = true;


    }

    // Update is called once per frame
    void Update()
    {


        HpBar();

        if (attackMode)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
            }
        }

        if (isMove) {
            Move();
        }

    }

    public void Move() {
       
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.05f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.02f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(0.05f, 0, 0);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }
    }

    public void AttackBtn() {
        if (!attackMode)
            attackMode = true;
        else
            attackMode = false;
    }

    public void Attack() {
        _anim.SetTrigger("Attack_Move");
    }
    public void HpBar() {
        _hpBar.fillAmount = (float) currentHp / (float) hp;     // casting de int para float
    }

 
   

}
