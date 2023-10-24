using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaibiour : MonoBehaviour
{

    public float speed;
    private PointsBehabiour scriptPointsBehaibiour;
    

    void Start()
    {

        scriptPointsBehaibiour = FindObjectOfType<PointsBehabiour>();
        
    }

    
    void Update()
    {
        float dt = Time.deltaTime;
        transform.Translate(Vector3.left.normalized * speed * dt);
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            scriptPointsBehaibiour.AddPoints(3) ;
        }
        Destroy(gameObject);
       
     
    }
}
