using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPattern : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pattern")
        {
            Instantiate(GameControl.instance.patternPool[Random.Range(0, GameControl.instance.patternPool.Length)], GameControl.instance.spawnPoint.transform.position, Quaternion.identity);
        }
    }

}
