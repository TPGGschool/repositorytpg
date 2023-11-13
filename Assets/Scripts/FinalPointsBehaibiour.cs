using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalPointsBehaibiour : MonoBehaviour
{

    private TMP_Text textComponent;
    private PointsBehabiour scriptPointsBehabiour;
   
    

    private void Start()
    {

        textComponent = GetComponent<TMP_Text>();
        scriptPointsBehabiour = FindObjectOfType<PointsBehabiour>();

    }


    void Update()
    {

        textComponent.text = "Score: " + scriptPointsBehabiour.puntos;

    }

   


}
