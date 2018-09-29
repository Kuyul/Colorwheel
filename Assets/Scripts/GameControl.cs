using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public static GameControl instance;

    public float patternScrollSpeed;
    public GameObject spawnPoint;
    public GameObject[] patternPool;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}



    public void EndGame()
    {
        // bla
    }
}
