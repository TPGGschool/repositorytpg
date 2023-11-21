using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENamySpawn : MonoBehaviour
{

    double timere = 3;
    double dife = 3;
    double timerc = 10;
    double difc = 10;
     public int mine;
     public int maxe;
    public int minc;
    public int maxc;
    public GameObject prefabEnemy;
    public GameObject prefabColor;

   

    private Textlives scriptTextlives;
    // Start is called before the first frame update
    void Start()
    {
        scriptTextlives = FindObjectOfType<Textlives>();
    }

    // Update is called once per frame
    void Update()
    {
        //enemigos
        float dt = Time.deltaTime;
        timere -= dt;
        if (timere <= 0 && scriptTextlives.vidas > 0) 
        {
            float posY = Random.Range(mine, maxe);
            Instantiate(prefabEnemy, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            timere =  dife;
            if (dife > 0.5)
            {
                dife -= 0.05;
            }
        }


        // colores

        timerc -= dt;
        if (timerc <= 0 && scriptTextlives.vidas > 0)
        {
         


            float posX = Random.Range(minc, maxc);
            Instantiate(prefabColor, new Vector3(posX, 13, 0), Quaternion.identity);
            timerc = difc;

           
        }

    }
}
