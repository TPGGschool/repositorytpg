using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaibiour : MonoBehaviour
{

    public float speed;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        float dt = Time.deltaTime;
        transform.Translate(Vector3.left.normalized * speed * dt);
    }

    private void OnCollisionEnter(Collision collision)
    {

           

            Destroy(collision.gameObject);
            Destroy(gameObject);
       
     
    }
}
