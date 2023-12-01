using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENamySpawn : MonoBehaviour
{
    private Textlives scriptTextlives;
    private SceneCounter scrSceneCounter;
    private IconBTWRound scrIconBTWRound;

    List<string> levels = new List<string>();


    float countdownTotal = 405;
    float waitTime = 5;
    float roundTime = 20;
    float thisRoundTime = 20;
    int round = 1;



    bool isroundover = true;
    bool hasinfoshowned = false;
    bool has1rstPowerupSpawned = false;
    bool has2ndPowerupSpawned = false;
    bool hasSharkTimerSeted = false;
    bool hasSwordTimerSeted = false;
    bool hasTurtTimerSeted = false;

    int savelistindex = 0;

    int lvlShark = 1;
    int lvlSword = 0;
    int lvlTurt = 0;

    public int mine;
    public int maxe;
    public int minc;
    public int maxc;

    public GameObject prefabEnemyShark;
    public GameObject prefabEnemySword;
    public GameObject prefabEnemyTurt;
    public GameObject prefabColor;
    // si uso los de arribaaaaaaaaaaaaaaaaaaaaaaa


    int randomenemy;






    float sharkTimer = 3.30f;
    float swordTimer = 3.85f;
    float turtTimer = 3.85f;

    float sharkTimersave = 3.30f;
    float swordTimersave = 3.85f;
    float turtTimersave = 3.85f;

    float sharkDelay = 0;
    float swordDelay = 0;
    float turtDelay = 0;





    int part = 1;







    void Start()
    {

        levels.Add("Shark");
        levels.Add("Shark");
        levels.Add("Sword");
        levels.Add("Sword");
        levels.Add("Sword");
        levels.Add("Turt");
        levels.Add("Turt");
        levels.Add("Turt");

        scriptTextlives = FindObjectOfType<Textlives>();
        scrSceneCounter = FindObjectOfType<SceneCounter>();
        scrIconBTWRound = FindObjectOfType<IconBTWRound>();



    }


    void Update()
    {

        float dt = Time.deltaTime;
        countdownTotal -= dt;
        thisRoundTime -= dt;
        float round2End = roundTime / 3;
        float round1End = (roundTime / 3) * 2;

        //partmanager

        if (thisRoundTime >= round1End)
        {

            part = 1;

        }
        else if (thisRoundTime >= round2End)
        {

            part = 2;
            PowerUpSpawn();


        }
        else
        {
            part = 3;
            PowerUp2Spawn();

        }


        if (waitTime > 0 && isroundover)
        {
            gapRounds(lvlShark, lvlSword, lvlTurt);
            ShowEndRound();

            
            scrIconBTWRound.ActiveSprites(true);

            if (round == 1)
            {
                scrIconBTWRound.BlinkArrow(scrIconBTWRound.Sharka1,4,false);

            }
        }
        else if (waitTime <= 0 && !isroundover)
        {

            scrIconBTWRound.ActiveSprites(false);

            hasinfoshowned = false;

            if (lvlShark > 0)
            {
                SharkSpawn(lvlShark);

            }
            if (lvlSword > 0)
            {

                SwordSpawn(lvlSword);

            }
            if (lvlTurt > 0)
            {

                TurtSpawn(lvlTurt);

            }

            if (thisRoundTime <= 0)
            {
                EndRound();
            }
        }
        else isroundover = false;





    }

    void gapRounds(int sharklev, int swordlev, int turtlev)
    {
        if (!hasinfoshowned)
        {
            Debug.Log("shark lvl: " + sharklev);
            Debug.Log("sword lvl: " + swordlev);
            Debug.Log("turt lvl: " + turtlev);
            hasinfoshowned = true;

        }

        waitTime -= Time.deltaTime;


    }

    void PowerUpSpawn()
    {


        if (!has1rstPowerupSpawned)
        {
            float posX = Random.Range(minc, maxc);
            Instantiate(prefabColor, new Vector3(posX, 13, 0), Quaternion.identity);
            has1rstPowerupSpawned = true;

        }




    }

    void PowerUp2Spawn()
    {
        if (!has2ndPowerupSpawned)
        {
            float posX = Random.Range(minc, maxc);
            Instantiate(prefabColor, new Vector3(posX, 13, 0), Quaternion.identity);
            has2ndPowerupSpawned = true;

        }

    }

    void EndRound()
    {
        if (levels.Count > 0)
        {

            savelistindex = Random.Range(0, levels.Count);

            if (levels[savelistindex] == "Shark")
            {
                lvlShark++;
                levels.RemoveAt(savelistindex);

            }
            else if (levels[savelistindex] == "Sword")
            {
                lvlSword++;
                levels.RemoveAt(savelistindex);
            }
            else if (levels[savelistindex] == "Turt")
            {
                lvlTurt++;
                levels.RemoveAt(savelistindex);
            }

            isroundover = true;
            waitTime = 5;
            roundTime += 5;
            thisRoundTime = roundTime;
            hasSharkTimerSeted = false;
            has1rstPowerupSpawned = false;
            has2ndPowerupSpawned = false;
            round++;

        }
        else
        {
            scrSceneCounter.ChangeToScene(2);
        }

        //if (round > 1)
        //{

        //    ShowEndRoundButDelayed();

        //}


    }

    void SharkSpawn(int sharklev)
    {
        float dt = Time.deltaTime;
        float posY = Random.Range(mine, maxe);


        sharkTimer -= dt;
        sharkDelay -= dt;

        if (hasSharkTimerSeted == false)
        {
            sharkTimer = (4 - sharklev + 1) - (part * 0.33f);
            hasSharkTimerSeted = true;
        }


        if (sharkTimer <= 0)
        {
            Instantiate(prefabEnemyShark, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            hasSharkTimerSeted = false;
        }


    }
    void SwordSpawn(int swordlev)
    {
        float dt = Time.deltaTime;
        float posY = Random.Range(mine, maxe);


        swordTimer -= dt;
        swordDelay -= dt;

        if (hasSwordTimerSeted == false)
        {
            swordTimer = (4 - swordlev + 1) - (part * 0.33f);
            hasSwordTimerSeted = true;
        }


        if (swordTimer <= 0)
        {
            Instantiate(prefabEnemySword, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            hasSwordTimerSeted = false;
        }
    }
    void TurtSpawn(int turtlev)
    {
        float dt = Time.deltaTime;
        float posY = Random.Range(mine, maxe);


        turtTimer -= dt;
        turtDelay -= dt;

        if (hasTurtTimerSeted == false)
        {
            turtTimer = (4 - turtlev + 1) - (part * 0.33f);
            hasTurtTimerSeted = true;
        }


        if (turtTimer <= 0)
        {
            Instantiate(prefabEnemyTurt, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
            hasTurtTimerSeted = false;
        }
    }

    int delayarrow = 1;
    void ShowEndRound()
    {


        if (lvlShark == 2)
        {
            scrIconBTWRound.BlinkArrow(scrIconBTWRound.Sharka2, 4,false);
            delayarrow = 2;


        }
        else if (lvlShark == 3)
        {


            scrIconBTWRound.BlinkArrow(scrIconBTWRound.Sharka3, 4,false);
            delayarrow = 3;
        }


        if (lvlSword == 1)
        {
            scrIconBTWRound.BlinkArrow(scrIconBTWRound.Sworda1, 4,false);
            delayarrow = 4;

        }
        else if (lvlSword == 2)
        {

            scrIconBTWRound.BlinkArrow(scrIconBTWRound.Sworda2, 4,false);
            delayarrow = 5;
        }
        else if (lvlSword == 3)
        {


            scrIconBTWRound.BlinkArrow(scrIconBTWRound.Sworda3, 4,false);
            delayarrow = 6;


        }

        if (lvlTurt == 1)
        {
            scrIconBTWRound.BlinkArrow(scrIconBTWRound.Turta1,4,false);
            delayarrow = 7;

        }
        else if (lvlTurt == 2)
        {

            scrIconBTWRound.BlinkArrow(scrIconBTWRound.Turta2,4,false);
            delayarrow = 8;
        }
        else if (lvlTurt == 3)
        {


            scrIconBTWRound.BlinkArrow(scrIconBTWRound.Turta3,4,false);
            delayarrow = 9;


        }

    }

    //void ShowEndRoundButDelayed()
    //{

    //    if (round == 2)
    //    {
    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Sharka1);
    //    }

    //    if (delayarrow == 2)
    //    {
    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Sharka2);



    //    }
    //    else if (delayarrow == 3)
    //    {


    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Sharka3);

    //    }


    //    if (delayarrow == 4)
    //    {
    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Sworda1);

    //    }
    //    else if (delayarrow == 5)
    //    {

    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Sworda2);
    //    }
    //    else if (delayarrow == 6)
    //    {


    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Sworda3);


    //    }

    //    if (delayarrow == 7)
    //    {
    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Turta1);

    //    }
    //    else if (delayarrow == 8)
    //    {

    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Turta2);
    //    }
    //    else if (delayarrow == 9)
    //    {


    //        scrIconBTWRound.AddToShowList(scrIconBTWRound.Turta3);


    //    }

    //}



}
