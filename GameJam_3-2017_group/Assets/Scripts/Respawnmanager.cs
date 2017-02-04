using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnmanager : MonoBehaviour
{
    public GameObject deadPlayer;
    public float seconds;

    public void Respawnplayer()
    {
        //instantiate dead player at the spawn
    }

    IEnumerator respawnTimer()
    {
        //time it takes to respawn the player
        //Example Below
        yield return new WaitForSecondsRealtime(seconds);
        //There are other versions of 'wait' in the scripting help

    }
}
