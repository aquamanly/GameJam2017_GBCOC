using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {
	public GameObject Respawnmanager;
	public float  playerhealth; //this is now a float type variable. A variable's type is defined as a few thigns
    public bool isAlive = true;
    public GameObject otherThing;
    public GameObject Red;
    public GameObject Green;
    public GameObject top;
    public GameObject left;
    public GameObject right;
    public GameObject bottom;
    

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

        if (other.gameObject == Red)
        {
            Destroy(Red);
            
        }
        else if (other.gameObject == Green)
        {
            Destroy(Green);
        }

    }

}
