using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour {
    public GameObject myelf;
    public GameObject myparent;
    public PointEffector2D sc;
    private bool exploded = false;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myelf.transform.parent != myparent.transform)
        
        {
            if (!exploded)
            {
                gameObject.GetComponent<CircleCollider2D>().radius = 10;
                sc = gameObject.AddComponent<PointEffector2D>() as PointEffector2D;
                sc.forceMagnitude = 500;
                sc.forceVariation = 100;
                exploded = true;
            }
           

            DestroyObject(gameObject, 0.5f);
        }
    }

 
}



