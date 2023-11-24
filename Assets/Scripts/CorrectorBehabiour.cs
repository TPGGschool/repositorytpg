using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectorBehabiour : MonoBehaviour
{
    private Spawn scrSpawn;

    // Start is called before the first frame update
    void Start()
    {
        scrSpawn = FindObjectOfType<Spawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        if (other.tag == "TopTrigger")
        {

            scrSpawn.ChangeCharSprite("top", "bla");
        }

        if (other.tag == "BotTrigger")
        {

            scrSpawn.ChangeCharSprite("bot", "bla");
        }

    }

   
}
