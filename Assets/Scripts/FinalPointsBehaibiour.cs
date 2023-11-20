using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalPointsBehaibiour : MonoBehaviour
{

    private TMP_Text textComponent;
    private SceneCounter scrSceneCounter;
   
    

    private void Start()
    {

        textComponent = GetComponent<TMP_Text>();
        scrSceneCounter = FindObjectOfType<SceneCounter>();

    }


    void Update()
    {

        textComponent.text = "Score: " + scrSceneCounter.puntos;

    }

   


}
