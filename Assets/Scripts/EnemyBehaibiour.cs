using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaibiour : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (CompareTag("Character"))
        {
           Destroy(collision.gameObject);
        }
    }
}
