using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    //enemies to spawn every 60 secconds
    public GameObject prefab;
    public GameObject spawnLocation;
    private Vector2 position;
    public float seconds;
    public GameObject newVil;

    void Start()
    {
        position = spawnLocation.transform.position;
        StartCoroutine(Spawn());

    }

    void Update()
    {

       
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(seconds);
            newVil =  Instantiate(prefab, position, Quaternion.identity);
            yield return new WaitForSecondsRealtime(seconds);
            Destroy(newVil);
        }
            
            
        
        
    }
}
