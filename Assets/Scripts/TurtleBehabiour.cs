using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleBehabiour : MonoBehaviour
{
    public float speed;
    private PointsBehabiour scriptPointsBehaibiour;
    private Spawn scrSpawn;
    public GameObject corrector;

    float countercorrector = 1f;
    public bool isitoncorrector = false;

    float timercorrector = 0.05f;

    void Start()
    {

        scriptPointsBehaibiour = FindObjectOfType<PointsBehabiour>();
        scrSpawn = FindObjectOfType<Spawn>();

    }


    void Update()
    {
        float dt = Time.deltaTime;
        transform.Translate(Vector3.left.normalized * speed * dt);
        countercorrector -= dt;

        if (countercorrector < 0)
        {

            Instantiate(corrector, new Vector3(transform.position.x +2,transform.position.y, 0), Quaternion.identity);

            countercorrector = 0.12f;
        }

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
