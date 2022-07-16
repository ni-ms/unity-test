using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Player
{
     
    public Enemy(int health,int power, string name)
    {
        Health = health;
        Power = power;
        Name = name;
    }

    public override void Attack()
    {
        Debug.Log("Enemy is attacking with weapon");
    }
}
