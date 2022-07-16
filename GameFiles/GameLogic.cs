using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    Player enemy;
    Player archer;
    // Start is called before the first frame update
    void Start()
    {
        enemy = new Enemy(9,10,"Warrior");
        enemy.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
