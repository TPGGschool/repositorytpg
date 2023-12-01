using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaibiour : MonoBehaviour
{

    public float speed;
    private PointsBehabiour scriptPointsBehaibiour;
    private Spawn scrSpawn;
    private SphereMovemente scrSphereMovemente;

    public bool isitoncorrector = false;

    float timercorrector = 0.05f;

    void Start()
    {

        scriptPointsBehaibiour = FindObjectOfType<PointsBehabiour>();
        scrSpawn = FindObjectOfType<Spawn>();
        scrSphereMovemente = FindObjectOfType<SphereMovemente>();

    }


    void Update()
    {
        
        float dt = Time.deltaTime;
        transform.Translate(Vector3.left.normalized * speed * dt);

        timercorrector -= dt;
        if (timercorrector < 0)
        {
            isitoncorrector = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {


       

        if (collision.gameObject.tag == "Bullet")
        {
           
            Destroy(collision.gameObject);

            if (isitoncorrector == false)
            {
                scriptPointsBehaibiour.AddPoints(3);
                
                Destroy(gameObject);
            }
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TopTrigger")
        {

            scrSpawn.ChangeCharSprite("top", "bla");
        }

        if (other.tag == "BotTrigger")
        {

            scrSpawn.ChangeCharSprite("bot", "bla");
        }



    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Corrector")
        {
            isitoncorrector = true;
            timercorrector = 0.05f;
        }

    }

   
}
