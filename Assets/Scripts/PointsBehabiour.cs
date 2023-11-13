using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsBehabiour : MonoBehaviour
{

    public TMP_Text textComponent;
     public int puntos = 10;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
     
        
    }

   
    void Update()
    {

        textComponent.text = "Score: " + puntos;
       
    }

    public void AddPoints(int value)
    {
        puntos = puntos + value;
    }




}
