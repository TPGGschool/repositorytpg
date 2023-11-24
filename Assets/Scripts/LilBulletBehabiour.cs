using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilBulletBehabiour : MonoBehaviour
{

    public Rigidbody rigidbodybullet;
    int randomup = 0;
    int randomright = 0;
    bool just1 = true;

    // Start is called before the first frame update
    void Start()
    {
        randomup = Random.Range(1, 10);
        randomright = Random.Range(-3, 4);
        rigidbodybullet.velocity = randomright * transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (just1)
        {
        rigidbodybullet.velocity = randomup * transform.up;
            just1 = false;
        }
        
    }
}
