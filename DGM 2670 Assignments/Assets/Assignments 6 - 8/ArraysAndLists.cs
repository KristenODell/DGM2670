using UnityEngine;
using System.Collections;

public class ArraysAndLists : MonoBehaviour
{
    //Pokemon Array List
    public GameObject[] pokemon;

    void Start()
    {
        pokemon = GameObject.FindGameObjectsWithTag("Pokemon");
    }

    void OnTriggerEnter()
    {
        for (int i = 0; i < pokemon.Length; i++)
        {
            print("You found " + pokemon.Length + " pokeballs. One is a " + pokemon[i].name);
        }

    }
}