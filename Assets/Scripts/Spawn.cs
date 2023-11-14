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
    public Rigidbody rigidbodysquid;



    void Start()
    {
        scriptTextlives = FindObjectOfType<Textlives>();
        scrPointsBehaibiour = FindObjectOfType<PointsBehabiour>();
    }

    private Vector3 direction = new Vector3(0, 0, 0);
    
    void Update()
    {
        float speedy = rigidbodysquid.velocity.y;

        float dt = Time.deltaTime;

        if (scriptTextlives.vidas <= 0)
        {
            Destroy(this.gameObject);
        }


        if (Input.GetKeyDown(KeyCode.Mouse0) && scrPointsBehaibiour.puntos >= 1)
        {
            Instantiate(sphere, transform.position, Quaternion.Euler(0, 0, 0));
            scrPointsBehaibiour.AddPoints(-1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
           

            if (speedy < 7f) 
            { 
             
              rigidbodysquid.velocity = 15 * transform.up;

            }
        }

       

        if (Input.GetKey(KeyCode.D))
        {
          
            direction.x = 1 ;
            direction.y = speedy / speed;
            transform.Translate(direction.normalized * speed * dt);
        }

        if (Input.GetKey(KeyCode.A))
        {
            
            direction.x = -1 ;
            direction.y = speedy / speed;
            transform.Translate(direction.normalized * speed * dt);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 13;
        } else
        {
            speed = 7;
        }

        

    }


   







}
