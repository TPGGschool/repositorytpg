using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject sphere;
    public int speed = 7;


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


       



    }


    private void FixedUpdate()
    {

        float dt = Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {

            

            if (PlayerMovementLimit(-7.75f, "right"))
            {
                direction.x = 0;
            }
            else direction.x = 1;



            transform.Translate(direction * speed * dt);

        }

        if (Input.GetKey(KeyCode.A))
        {
            if (PlayerMovementLimit(-44f, "left"))
            {
                direction.x = 0;
            }
            else direction.x = -1;



            transform.Translate(direction * speed * dt);


        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 13;
        }
        else
        {
            speed = 7;
        }

    }

    bool PlayerMovementLimit(float limit, string limitside)
    {

        if (limitside == "right")
        {
            if (transform.position.x >= limit)
            {
                return true;
            }
            else return false;

            
        }
        else if (limitside == "left")
        {
            if (transform.position.x <= limit)
            {
                return true;
            }
            else return false;

        } else
        {
            return false;
        }

        
    }





}
