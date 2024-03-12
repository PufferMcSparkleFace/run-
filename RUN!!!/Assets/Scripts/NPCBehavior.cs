using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public Material zombieMaterial;
    private GameObject zombie;
    public float speed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, zombie.transform.position, speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie" || collision.gameObject.tag == "Zombie King")
        {
            gameObject.GetComponent<MeshRenderer>().material = zombieMaterial;
            gameObject.tag = "Zombie";
            int ZombieLayer = LayerMask.NameToLayer("Zombie");
            gameObject.layer = ZombieLayer;
            StartCoroutine(Transform());
        }
    }

    IEnumerator Transform()
    {
        yield return new WaitForSeconds(1.5f);
        zombie = GameObject.Find("Zombie");

    }
}
