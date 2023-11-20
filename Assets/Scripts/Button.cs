using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button : MonoBehaviour
{

    private PointsBehabiour scriptPointsBehaibiour;
    private SceneCounter scriptSceneCounter;

    private void Start()
    {

        scriptPointsBehaibiour = FindObjectOfType<PointsBehabiour>();
        scriptSceneCounter = FindObjectOfType<SceneCounter>();
    }
    public void BotonJugar()
    {
        scriptSceneCounter.ChangeToScene(1);
    }

}