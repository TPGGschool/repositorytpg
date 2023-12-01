using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IconBTWRound : MonoBehaviour
{

    public GameObject Shark;
    public GameObject Sword;
    public GameObject Turt;

    public GameObject Sharka1;
    public GameObject Sharka2;
    public GameObject Sharka3;

    public GameObject Sworda1;
    public GameObject Sworda2;
    public GameObject Sworda3;

    public GameObject Turta1;
    public GameObject Turta2;
    public GameObject Turta3;


    float timerblink = 0.5f;

    List<GameObject> Show = new List<GameObject>();

    private void Start()
    {
        Show.Add(Shark);
        Show.Add(Sword);
        Show.Add(Turt);

    }


    public void ActiveSprites(bool active)
    {


        for (int i = 0; i < Show.Count; i++)
        {
            Show[i].SetActive(active);

        }



    }

    public void AddToShowList(GameObject addthis)
    {

        bool isrepeated = false;



        for (int i = 0; i < Show.Count; i++)
        {
            if (addthis == Show[i])
            {
                isrepeated = true;

            }

        }

        if (!isrepeated)
        {
            Show.Add(addthis);
        }
    }

    bool threadAlive = false;
    public void BlinkArrow(GameObject arrow, float forsecs, bool forsecsended)
    {
        float dt = Time.deltaTime;

        timerblink -= dt;
        forsecs -= dt;
        
        



        if (timerblink <= 0 && !forsecsended)
        {
            arrow.SetActive(threadAlive);
            timerblink = 0.5f;


            if (!forsecsended)
            {
                if (threadAlive)
                {
                    threadAlive = false;
                }
                else
                {
                    threadAlive = true;

                }

            }







        }
        else AddToShowList(arrow);


        if (forsecs <= 0)
        {
            threadAlive = false;
            forsecsended = true;
        }

    }
}