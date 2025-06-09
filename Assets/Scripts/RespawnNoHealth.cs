using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RespawnNoHealth : MonoBehaviour
{
    public float yRespawnValue;

    void Start()
    {

    }

    void Update()
    {
        if (HealthManager <=0 < yRespawnValue)
        {
            SceneManager.LoadScene("FPS Parkour");
        }

    }
}
