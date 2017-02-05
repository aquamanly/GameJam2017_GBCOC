using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    //enemies to spawn every 60 secconds
    public GameObject redPrefab;
    public GameObject redSpawnLocation;
    private Vector2 redPosition;
    public float redSecondsToSpawnAVillain;
    public GameObject redNewVil;

    public GameObject greenPrefab;
    public GameObject greenSpawnLocation;
    private Vector2 greenPosition;
    public float greenSecondsToSpawnAVillain;
    public GameObject greenNewVil;

    public float secondsTillCharacterDestroysItself;

    void Start()
    {
        redPosition = redSpawnLocation.transform.position;
        greenPosition = greenSpawnLocation.transform.position;
        StartCoroutine(Spawn());

    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(redSecondsToSpawnAVillain);
            yield return new WaitForSecondsRealtime(greenSecondsToSpawnAVillain);
            redNewVil =  Instantiate(redPrefab, redPosition, Quaternion.identity);
            greenNewVil = Instantiate(greenPrefab, greenPosition, Quaternion.identity);
            yield return new WaitForSecondsRealtime(secondsTillCharacterDestroysItself);
            Destroy(redNewVil);
            Destroy(greenNewVil);
        }
            
            
        
        
    }
}
