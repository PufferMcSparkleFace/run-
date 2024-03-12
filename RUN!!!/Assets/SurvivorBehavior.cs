using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivorBehavior : MonoBehaviour
{
    public GameObject timerText;
    public GameOverScreen gameOver;
    public Rigidbody rb;
    public float moveSpeed;

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
        if(collision.gameObject.tag == "Zombie")
        {
            timerText.SetActive(false);
            gameOver.GameOver(0);
        }
    }
}
