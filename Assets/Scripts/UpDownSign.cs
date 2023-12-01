using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpDownSign : MonoBehaviour
{

    public TMP_Text textComponent;
    private Spawn scrSpawn;


    private void Start()
    {


        scrSpawn = FindObjectOfType<Spawn>();


    }


    void Update()
    {
        if (scrSpawn.lastside == "top")
        {
            textComponent.text = ">";

        }
        else if (scrSpawn.lastside == "bot")
        {
            textComponent.text = "<";

        }


    }
}

   
