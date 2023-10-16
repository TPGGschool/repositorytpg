using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovemente : MonoBehaviour
{

    public int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        transform.Translate (Vector3.right.normalized * speed * dt);
    }
}
