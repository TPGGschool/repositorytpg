using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        gameover();
    }

    public void Loselives(int value)
    {

        if (vidas > 0)
        {
            vidas = vidas - value;
        }
    }

    public void gameover()
    { 
        if (vidas <= 0)
        {
        SceneManager.LoadScene(2);

        }
    
    }

}