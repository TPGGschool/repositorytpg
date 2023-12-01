using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehabiour : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private Spawn scrSpawn;
    public Sprite azuColor;
    public Sprite rosColor;
    public Sprite curColor;
    private Textlives scrTextLives;
    private ENamySpawn scrENamySpawn;
    int randomcol = 0;
    string colType = "azu";



    void Start()
    {
        scrENamySpawn = FindObjectOfType<ENamySpawn>();
        scrSpawn = FindObjectOfType<Spawn>();
        scrTextLives = FindObjectOfType<Textlives>();

        randomcol = Random.Range(0, 3);

        if (randomcol == 0)
        {
            colType = "azu";

        }
        else if (randomcol == 1)
        {
            colType = "ros";
        }
        else if (randomcol == 2)
        {
            colType = "cur";
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
        else if (colType == "cur")
        {
            spriteRenderer.sprite = curColor;

        }
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TopTrigger" || other.tag == "BotTrigger")
        {

            if (colType == "cur")
            {
                scrTextLives.Loselives(-1);
            }
            else
            {
                scrSpawn.ChangeCharSprite(scrSpawn.lastside, colType);
            }



            Destroy(gameObject);
        }

        if (other.tag == "Limit")
        {


            Destroy(gameObject);
        }
    }
}
