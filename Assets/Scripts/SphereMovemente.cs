using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovemente : MonoBehaviour
{

    public int speed = 20;
    private Spawn scrSpawn;
    public GameObject lilbullet;
    // Start is called before the first frame update
    void Start()
    {
        scrSpawn = FindObjectOfType<Spawn>();
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        transform.Translate (Vector3.right.normalized * speed * dt);
        

        
    }


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("3");
        if (other.CompareTag("Enemy") && scrSpawn.topcol == "azu")
        {
            bluebullet();
            Debug.Log("2");
        }
    }
    private void bluebullet()
    {
            Instantiate(lilbullet, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Instantiate(lilbullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Instantiate(lilbullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        Debug.Log("1");

    }
}
