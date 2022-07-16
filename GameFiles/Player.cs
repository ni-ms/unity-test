using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

private int _health;
public int Health {
    get { return _health; }
    set { _health = value; }
}
private int _power;
public int Power {
    get { return _power; }
    set { _power = value; }
}
private string _name;
public string Name {
    get { return _name; }
    set { _name = value; }
}


public Player() {
    Debug.Log("Loaded");
}

public Player(int health, int power, string name){
    Health = health;
    Power = power;
    Name = name;
}
public virtual void Attack(){
    Debug.Log("Attacked");
}
public void Info(){
    Debug.Log("Health - " + Health); 
    Debug.Log("Power - " + Power); 
    Debug.Log("Name - " + Name); 
}
}
