using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int level = 1;
    public int baseXp;
    public int attack;


    public float distanceToFollow;
    public Transform Player;
    private Player player;
    public float stoppingDistance;
    private float currentDistancePlayer;
    private Vector3 playerposition;

    public float Health = 100;
    public float MaxHealth;
    

    public GameObject healthBar;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType(typeof(Player)) as Player;
        Health = MaxHealth;
        Health *= level;
        attack *= level;
        baseXp *= level;
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateHealth();
        transform.LookAt(Player);
        playerposition = player.transform.position;

        currentDistancePlayer = Vector3.Distance(transform.position, playerposition);

        if(currentDistancePlayer < distanceToFollow)
        {
            if (Vector3.Distance(transform.position, Player.position) > stoppingDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
            }
              
        }

        if(Health < MaxHealth)
        {
            healthBar.SetActive(true);
        }

        if(Health > MaxHealth)
        {
            Health = MaxHealth;
        }

        /*if (Vector3.Distance(transform.position, Player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }*/

       
        float CalculateHealth()
        {
            return Health / MaxHealth;
        }
    }





}
