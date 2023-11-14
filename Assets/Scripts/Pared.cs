using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    private Textlives scriptTextlives;

    private void Start()
    {
        scriptTextlives = FindObjectOfType<Textlives>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bullet")
        {

            if (collision.gameObject.tag == "Enemy")
            {

                scriptTextlives.Loselives(1);
            }
            Destroy(collision.gameObject);
        }


    }


}
