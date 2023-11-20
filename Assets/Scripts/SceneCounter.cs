using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCounter : MonoBehaviour
{
    
    public static SceneCounter instance;
    int scene = 0;
    public int puntos = 0;
    void Start()
    {
        
    }

    
    void Update()
    {


    }

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


    public void ChangePuntos(int p)
    {
        puntos = p;
    }
    public void ChangeToScene(int SceneNumber)
    {
        int scene = SceneNumber;
        SceneManager.LoadScene(SceneNumber);
      
    }

}
