using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehabiour : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private Spawn scrSpawn;
    public Sprite azuColor;
    public Sprite rosColor;
    private ENamySpawn scrENamySpawn;
    int randomcol = 0;
    string colType = "azu";



    void Start()
    {
        scrENamySpawn = FindObjectOfType<ENamySpawn>();

        randomcol = Random.Range(0, 2);

        if (randomcol == 0)
        {
            colType = "azu";

        }
        else if (randomcol == 1)
        {
            colType = "ros";
        }





        scrSpawn = FindObjectOfType<Spawn>();

        if (colType == "azu")
        {
            spriteRenderer.sprite = azuColor;
        }
        else if (colType == "ros")
        {
            spriteRenderer.sprite = rosColor;

        }
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TopTrigger" || other.tag == "BotTrigger")
        {


            scrSpawn.ChangeCharSprite(scrSpawn.lastside, colType);



            Destroy(gameObject);
        }

        if (other.tag == "Limit")
        {


            Destroy(gameObject);
        }
    }
}
