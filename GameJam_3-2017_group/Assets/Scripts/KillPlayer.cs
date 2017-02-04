using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
	public GameObject Respawnmanager;
	public float  playerhealth; //this is now a float type variable. A variable's type is defined as a few thigns
    public bool isAlive = true;
    public GameObject otherThing;

	void Start () {
        //Respawnmanager = FindObjectOfType<GameObject> ();	
        //^ this is commented out because I didn't know what it was used for
        
	}
	
    //I removed the Update function because it wasn't being used.
    //at least not now.

	void OnTriggerEnter2D(Collider2D other)
	{
		if (isAlive == false)
            //you forgot to close in the 'if' statement
            // intead of if(true)
            //you wrote if true) < the condition must be in parenthesis.
		{
            otherThing.GetComponent<Respawnmanager>();
            //^you can't reference an object or it's function this way
        }

	}

}
