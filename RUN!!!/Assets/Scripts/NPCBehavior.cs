using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public Material zombieMaterial;
    private GameObject zombie;
    private Vector3 zombiePosition;
    public float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zombiePosition = new Vector3(zombie.transform.position.x, zombie.transform.position.y, zombie.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, zombiePosition, speed);
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
