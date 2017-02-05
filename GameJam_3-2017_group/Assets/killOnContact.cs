using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killOnContact : MonoBehaviour
{

    public GameObject Red;
    public GameObject Green;



    void OnTriggerEnter2D(Collider2D other)
    {

        //Destroy(other.gameObject);
        other.enabled = false;

    }
}