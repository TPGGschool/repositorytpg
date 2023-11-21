using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject sphereBla;
    public GameObject sphereAzu;
    public GameObject sphereRos;
    public GameObject stainBla, stainAzu, stainRos;
    public int speed = 7;

    public SpriteRenderer spriteRenderer;
    public Sprite blabla, blaazu, azubla, azuazu, blaros, rosbla, azuros, rosazu, rosros;
    string topcol = "bla";
    string botcol = "bla";
    public string lastside = "top";


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


        if (Input.GetKeyDown(KeyCode.Mouse0) && scrPointsBehaibiour.puntos >= 1 && !Input.GetKey(KeyCode.Mouse1))
        {
            if (topcol == "bla")
            {

              Instantiate(sphereBla, transform.position, Quaternion.Euler(0, 0, 0));
            }
            else if (topcol == "azu")
            {
                Instantiate(sphereAzu, transform.position, Quaternion.Euler(0, 0, 0));
            }
            else if (topcol == "ros")
            {
                Instantiate(sphereRos, transform.position, Quaternion.Euler(0, 0, 0));
            }



            scrPointsBehaibiour.AddPoints(-1);
        }


        if (Input.GetKey(KeyCode.Mouse1) && scrPointsBehaibiour.puntos >= 1 && Input.GetKeyDown(KeyCode.Space))
        {
            if (botcol == "bla")
            {

                Instantiate(stainBla, transform.position, Quaternion.Euler(0, 0, 0));
            }
            else if (botcol == "azu")
            {
                Instantiate(stainAzu, transform.position, Quaternion.Euler(0, 0, 0));
            }
            else if (botcol == "ros")
            {
                Instantiate(stainRos, transform.position, Quaternion.Euler(0, 0, 0));
            }

            scrPointsBehaibiour.AddPoints(-1);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {


            if (speedy < 7f)
            {

                rigidbodysquid.velocity = 15 * transform.up;

            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        { lastside = "top"; }
        if (Input.GetKeyDown(KeyCode.S))
        { lastside = "bot"; }





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

        }
        else
        {
            return false;
        }


    }

    public void ChangeCharSprite(string side, string color)
    {
        if (side == "top")
        {

            if (color == "bla")
            {
                topcol = "bla";
            }

            if (color == "azu")
            {
                topcol = "azu";
            }

            if (color == "ros")
            {
                topcol = "ros";
            }

        }

        if (side == "bot")
        {

            if (color == "bla")
            {
                botcol = "bla";
            }

            if (color == "azu")
            {
                botcol = "azu";
            }

            if (color == "ros")
            {
                botcol = "ros";
            }

        }



        if (topcol == "bla" && botcol == "bla")
        {

            spriteRenderer.sprite = blabla;
        }
        if (topcol == "bla" && botcol == "azu")
        {

            spriteRenderer.sprite = blaazu;
        }
        if (topcol == "azu" && botcol == "bla")
        {

            spriteRenderer.sprite = azubla;
        }
        if (topcol == "azu" && botcol == "azu")
        {

            spriteRenderer.sprite = azuazu;
        }
        if (topcol == "bla" && botcol == "ros")
        {

            spriteRenderer.sprite = blaros;
        }
        if (topcol == "azu" && botcol == "ros")
        {

            spriteRenderer.sprite = azuros;
        }
        if (topcol == "ros" && botcol == "bla")
        {

            spriteRenderer.sprite = rosbla;
        }
        if (topcol == "ros" && botcol == "azu")
        {

            spriteRenderer.sprite = rosazu;
        }
        if (topcol == "ros" && botcol == "ros")
        {

            spriteRenderer.sprite = rosros;
        }

    }





}
