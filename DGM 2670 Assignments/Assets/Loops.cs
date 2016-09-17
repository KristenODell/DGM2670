using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour
{
        public string[] arielSisters = { "Aquata", "Andrina", "Arista", "Attina", "Adella", "Alana" };
        public string[] hobbies = { "sing", "read", "swim"};

    void Start()
    {
        foreach (string item in arielSisters)
        {
            foreach (string hobby in hobbies)
            {
                print("Hello! My name is " + item + ". I love to " + hobby + "!");
            }
        }
    }
}
