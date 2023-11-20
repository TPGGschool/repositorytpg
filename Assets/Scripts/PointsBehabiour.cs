using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsBehabiour : MonoBehaviour
{

    public TMP_Text textComponent;
    public SceneCounter scrSceneCounter;

     public int puntos = 10;

    private void Start()
    {

        puntos = 10;
        scrSceneCounter = FindObjectOfType<SceneCounter>();


    }

   
    void Update()
    {

        textComponent.text = "Score: " + puntos;
        scrSceneCounter.ChangePuntos(puntos);
       
    }

    public void AddPoints(int value)
    {
        puntos = puntos + value;
    }

    public void ResetPoints(int value)
    {
        puntos = value;
    }

    
    //-------------------------------- nodestroy

  
    



}
