using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovemente : MonoBehaviour
{

    public int speed = 1;
    int t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        t++;
        transform.position = new Vector3(t * speed * dt, 0, 0) ;
    }
}
