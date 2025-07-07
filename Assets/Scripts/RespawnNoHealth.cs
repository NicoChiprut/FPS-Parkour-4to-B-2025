using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RespawnNoHealth : MonoBehaviour

{
    public HealthManager healthManager;
    public float yRespawnValue;

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void Update()
    {
        if (healthManager.UpdateHealth)
        {
            SceneManager.LoadScene("FPS Parkour");
        }

    }
}
