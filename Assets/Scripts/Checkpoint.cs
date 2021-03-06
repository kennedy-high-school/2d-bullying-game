﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public LevelManager levelManager;

    void Start() {
        levelManager = FindObjectOfType<LevelManager>();
    }

    void Update () {
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.currentCheckpoint = gameObject;
            Debug.Log("Activate Checkpoint " + transform.position);
        }

    }

}
