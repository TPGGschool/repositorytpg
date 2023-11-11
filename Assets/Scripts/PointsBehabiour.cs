using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsBehabiour : MonoBehaviour
{

    private TMP_Text textComponent;
     public int puntos = 10;

    private void Start()
    {

        textComponent = GetComponent<TMP_Text>();
        
    }

   
    void Update()
    {

        textComponent.text = "Score: " + puntos;
        savepointsdata();
       
    }

    public void AddPoints(int value)
    {
        puntos = puntos + value;
    }

    public string pointssv = "puntos";
    public void savepointsdata()
    {
        PlayerPrefs.SetInt(pointssv, puntos);

    }

   


}
