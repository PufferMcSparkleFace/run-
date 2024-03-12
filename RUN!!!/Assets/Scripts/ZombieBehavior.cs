using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieBehavior : MonoBehaviour
{

    public GameOverScreen gameOver;
    public GameObject timerText;
    public Material zombieMaterial;
    public float moveSpeed = 200;
    public float horizontal;
    public float vertical;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            horizontal = 1;
        }

        if (Input.GetKey("a"))
        {
            horizontal = -1;
        }

        if (Input.GetKey("w"))
        {
            vertical = 1;
        }

        if (Input.GetKey("s"))
        {
            vertical = -1;
        }

        rb.velocity = new Vector3(horizontal * moveSpeed, 0, vertical * moveSpeed);
    }
}
