using UnityEngine;
using System.Collections;

public class ArraysAndLists : MonoBehaviour
{
    //Pokemon Array List
    public GameObject[] pokemon;
    public int donuts = 12;

    void Start()
    {
        pokemon = GameObject.FindGameObjectsWithTag("Pokemon");
    }

    public void OnTriggerEnter()
    {
        for (int i = 0; i < pokemon.Length; i++)
        {
            print("You found " + pokemon.Length + " pokeballs. One is a " + pokemon[i].name);
        }

    }
}