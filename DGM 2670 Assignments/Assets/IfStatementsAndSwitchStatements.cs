using UnityEngine;
using System.Collections;
using System;

public class IfStatementsAndSwitchStatements : MonoBehaviour
{

    int age = 0;
    int deathAge = 7;

    Action GrowingOld;
    Action Life;


    void Start ()
    {
        GrowingOld = GrowingOldHandler;
        Life = LifeHandler;
    }

    void GrowingOldHandler()
    {
        while (age < deathAge)
        {
            age++;
            Life();
        }
    }

    void LifeHandler()
    {
        switch (age)
        {
            case 0:
                print("I'm alive!");
                break;

            case 1:
                print("I'm a baby!");
                break;

            case 2:
                print("I'm a toddler!");
                break;

            case 3:
                print("I'm a big kid now!");
                break;

            case 4:
                print("I'm a teenager. Life sucks.");
                break;

            case 5:
                print("I'm an adult now! I can vote!");
                break;

            case 6:
                print("I'm already 55? Where does the time go?");
                break;

            case 7:
                print("I died.");
                break;

            default:
                GrowingOld = null;
                break;
        }

    }


    void Update()
    {
        if (age == deathAge)
        {
            Life = null;
        }
        if (Life != null)
        {
            Life();
        }
        if (GrowingOld != null)
        {
            GrowingOld();
        }
    }
}

