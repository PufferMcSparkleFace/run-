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
            rb.AddForce(moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "NPC")
        {
            collision.gameObject.tag = "Zombie";
            collision.gameObject.GetComponent<MeshRenderer>().material = zombieMaterial;
        }
        if(collision.gameObject.tag == "Player")
        {
            timerText.SetActive(false);
            gameOver.GameOver(0);
        }
    }
}
