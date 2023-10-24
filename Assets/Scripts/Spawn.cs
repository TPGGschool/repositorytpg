using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject sphere;
    public int speed = 7;
    private Vector3 spawnPoint = new Vector3(0, 7, 0);


    private Textlives scriptTextlives;
    private PointsBehabiour scrPointsBehaibiour;
    void Start()
    {
        scriptTextlives = FindObjectOfType<Textlives>();
        scrPointsBehaibiour = FindObjectOfType<PointsBehabiour>();
    }

    
    void Update()
    {
        float dt = Time.deltaTime;

        if (scriptTextlives.vidas <= 0)
        {
            Destroy(this.gameObject);
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(objectToSpawn,spawnPoint, Quaternion.Euler(53,7,12));
        }
            
        if (Input.GetKeyDown(KeyCode.Space) && scrPointsBehaibiour.puntos >= 1)
        {
            Instantiate(sphere, transform.position, Quaternion.Euler(53, 7, 12));
            scrPointsBehaibiour.AddPoints(-1);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up.normalized * speed * dt);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down.normalized*speed * dt);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right.normalized * speed * dt);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left.normalized * speed * dt);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 15;
        } else
        {
            speed = 7;
        }
    }

   
}
