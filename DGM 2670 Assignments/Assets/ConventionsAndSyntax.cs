using UnityEngine;
using System.Collections;

public class ConventionsAndSyntax : MonoBehaviour
{

    // Double forward slash allows you to do one line of comment.
    /* Forward slash and asterisk allow you to do multiple lines of comments.
     *Here is another comment.
     *Asterisk and forward slash ends the comment.
     */
    public bool harryPotter = true;

	void Start ()
    {
        WhereIsHarryPotter();
	}

    void WhereIsHarryPotter ()
    {
        if(harryPotter == true)
        {
            //End all statements that don't have curly brackets with a semicolon.
            print("Harry Potter is at Hogwarts");
        }
        else
        {
            print("Harry Potter is at the Dursley's house.");
        }
    }
}
