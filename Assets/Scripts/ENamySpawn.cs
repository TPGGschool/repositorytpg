using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENamySpawn : MonoBehaviour
{

    float timer = 3;
     public int min;
     public int max;
    public GameObject prefabEnemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float dt = Time.deltaTime;
        timer = timer - dt;
        if (timer <= 0)
        {
            float posY = Random.Range(min, max);
            Instantiate(prefabEnemy, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            timer = 2;
        }

    }
}
