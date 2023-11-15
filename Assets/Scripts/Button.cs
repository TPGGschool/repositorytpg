using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    private PointsBehabiour scriptPointsBehaibiour;

    private void Start()
    {

        scriptPointsBehaibiour = FindObjectOfType<PointsBehabiour>();
    }
    public void BotonJugar()
    {
        scriptPointsBehaibiour.ResetPoints(10);
        SceneManager.LoadScene(1);
    }
}
