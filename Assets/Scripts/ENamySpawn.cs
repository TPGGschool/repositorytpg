using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENamySpawn : MonoBehaviour
{

    double timer = 3;
    double dif = 3;
     public int min;
     public int max;
    public GameObject prefabEnemy;

    private Textlives scriptTextlives;
    // Start is called before the first frame update
    void Start()
    {
        scriptTextlives = FindObjectOfType<Textlives>();
    }

    // Update is called once per frame
    void Update()
    {

        float dt = Time.deltaTime;
        timer -= dt;
        if (timer <= 0 && scriptTextlives.vidas > 0) 
        {
            float posY = Random.Range(min, max);
            Instantiate(prefabEnemy, new Vector3(transform.position.x, posY, -1f), Quaternion.identity);
            timer =  dif;
            if (dif > 0.1)
            {
                dif -= 0.05;
            }
        }

    }
}
