using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStartButton : MonoBehaviour
{
    public void BotonJugar()
    {
        SceneManager.LoadScene(0);
    }
}
