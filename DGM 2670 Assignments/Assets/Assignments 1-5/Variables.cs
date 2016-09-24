using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour
{
    //Public integer variables to represent the maximum amount of presents, minimum amount of presents, and the actual amount of presents.
    public int maxPresents = 20;
    public int minPresents = 10;
    public int presents = 15;

    // Use this for initialization
    void Start()
    {
        if (presents >= maxPresents)
        {
            print("Thanks for all of the presents!");
        }
        else if (presents <= minPresents)
        {
            print("I want more presents! NOW!");
        }
        else
        {
            print("Are there anymore presents for me?");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}