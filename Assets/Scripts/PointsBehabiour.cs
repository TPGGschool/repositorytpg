using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsBehabiour : MonoBehaviour
{

    private TMP_Text textComponent;
    public int puntos = 0;
    
    private void Start()
    {

        textComponent = GetComponent<TMP_Text>();
        
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
