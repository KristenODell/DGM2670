using UnityEngine;
using System.Collections;

public class Superhero
{
    public int awesomeness;

    public Superhero ()
    {
        awesomeness = 10;
        Debug.Log("Superhero gets " + awesomeness + " points.");
    }
    public Superhero (int newAwesomeness)
    {
        awesomeness = newAwesomeness;
        Debug.Log("Superhero is awesome.");
    }
}


