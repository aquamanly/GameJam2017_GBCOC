using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public partial class EnemyAI : MonoBehaviour{
    //enemies walk to the opposite side of the map until they reach the tower
    //enemies place the bomb
    //the bomb detonates
    //the enemy and the bomb dissapears
    public Rigidbody2D rb;
    public bool radio = false;
    public int frame;
    public float Direction;
    public float seconds;

    void Start()
    {
        //necesary for finding the object's body to move it using physics
        rb = GetComponent<Rigidbody2D>();
        //this happens at the beginning of our program
        
    }

    //great for physics calculations
    void FixedUpdate()
    {
        Direction = -2;
        if (radio)
            StartCoroutine(MovingIntern());
        //our intern moves to the left.
        //This could be an inherited class that changes based off of what type of 
        //intern you are
    }


    IEnumerator MovingIntern()
    {
        rb.velocity = new Vector2(Direction, 0);
        yield return new WaitForSecondsRealtime(seconds);
        radio = false;
    }

    IEnumerator PlaceObstacle()
    {
        yield return new WaitForSecondsRealtime(seconds);
    }

    void Update()
    {

    }
}
