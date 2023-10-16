using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

        int Rnum = Random.Range(3, 5);
    }
}
