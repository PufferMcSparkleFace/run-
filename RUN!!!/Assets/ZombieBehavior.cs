﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieBehavior : MonoBehaviour
{

    public GameOverScreen gameOver;
    public GameObject timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "NPC")
        {

        }
        if(collision.gameObject.tag == "Player")
        {
            timerText.SetActive(false);
            gameOver.GameOver(0);
        }
    }
}