﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl instance;

    public float patternScrollSpeed;
    public GameObject spawnPoint;
    public GameObject[] patternPool;

    public GameObject mainPanel;
    public GameObject defaultPattern;

    public GameObject pe1;

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

        defaultPattern.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        Application.targetFrameRate = 300;
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(GameObject.Find("pe1(Clone)"), 0.5f);
    }



    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        defaultPattern.SetActive(true);
        mainPanel.SetActive(false);
    }
}
