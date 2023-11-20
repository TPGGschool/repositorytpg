using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToStartButton : MonoBehaviour
{
    private SceneCounter scriptSceneCounter;

    private PointsBehabiour scriptPointsBehaibiour;

    private void Start()
    {

        scriptSceneCounter = FindObjectOfType<SceneCounter>();
        scriptPointsBehaibiour = FindObjectOfType<PointsBehabiour>();
    }
    public void BotonJugar()
    {
        scriptSceneCounter.ChangeToScene(0);
    }
}
