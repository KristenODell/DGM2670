using UnityEngine;
using System.Collections;


public class Functions : MonoBehaviour
{

    float hoursWorked = 0;
    float dollarsPerHour = 1.00f;
    float moneyEarned;
    float hoursToWorkForToyCar;
    public float toyCarCost = 10.00f;
    float FirstHourPaycheck;



    // Use this for initialization
    void Start()
    {

        MoneySavedForToyCar();
    }


    void MoneySavedForToyCar()
    {
        hoursToWorkForToyCar = toyCarCost / dollarsPerHour;
        FirstHourPaycheck = dollarsPerHour;

        while (hoursWorked < hoursToWorkForToyCar)
        {
            moneyEarned = FirstHourPaycheck + hoursWorked * dollarsPerHour;
            print("I don't have enough money for a toy car.");
            hoursWorked++;
        }

        if (moneyEarned == toyCarCost)
        {
            print("I can buy a toy car!");
        }

    }
}
