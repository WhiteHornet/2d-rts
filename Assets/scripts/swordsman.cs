using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Linq;
using UnityEngine;

public class swordsman :Unit {

    public int health
    {
        get { return health; }
        set { health = value; }
    }



    public int speed
    {
        get { return speed; }
        set { speed = value; }
    }



    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }



    public int atkistance
    {
        get { return atkdistance; }
        set { atkdistance = value; }
    }



    public int faction
    {
        get { return faction; }
        set { faction = value; }
    }


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    //if (moonfaction)
    //{
    //    if (archer)
    //    {
    //        health = 40;
    //        attack = 25;
    //        def = 10;
    //    }
    //    else if (swordsman)
    //    {
    //        health = 60;
    //        attack = 15;
    //        def = 9;
    //    }
    //}
}
