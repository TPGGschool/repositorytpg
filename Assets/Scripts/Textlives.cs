using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Textlives : MonoBehaviour
{

    private TMP_Text textComponent;
    public int vidas = 3;

    private void Start()
    {

        textComponent = GetComponent<TMP_Text>();

    }


    void Update()
    {

        textComponent.text = "Lives: " + vidas;

    }

    public void Loselives(int value)
    {

        if (vidas > 0)
        {
            vidas = vidas - value;
        }
    }


}