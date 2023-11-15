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

        
     
        
    }

   
    void Update()
    {

        textComponent.text = "Score: " + puntos;
       
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

    public static PointsBehabiour instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);

    }



}
