using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivorBehavior : MonoBehaviour
{
    public GameObject timerText;
    public GameOverScreen gameOver;

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
        if(collision.gameObject.tag == "Zombie")
        {
            timerText.SetActive(false);
            gameOver.GameOver(0);
        }
    }
}
