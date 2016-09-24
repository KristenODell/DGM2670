using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int donutsPerPokemon;
    public int numberofPokemon = 4;
    public int _d;

    void Start ()
    {
        GameObject thePresent = GameObject.Find("Present");
        ArraysAndLists accessingList = thePresent.GetComponent<ArraysAndLists>();
        _d = accessingList.donuts;
        Donuts();
    }

	void Donuts ()
    {
        donutsPerPokemon = _d / numberofPokemon;
        print("Here are " + donutsPerPokemon + " donuts for each of your pokemon.");
	}
}
