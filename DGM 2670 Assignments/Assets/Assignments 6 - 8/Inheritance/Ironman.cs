using UnityEngine;
using System.Collections;

public class Ironman : Superhero
{
    public Ironman ()
    {
        awesomeness = 100;
        Debug.Log("Ironman gets " + awesomeness + " points.");
    }
    public Ironman(int newAwesomeness) : base(newAwesomeness)
    {
        Debug.Log("Ironman is awesome.");
    }
}
