﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RespawnOnFall : MonoBehaviour
{
    public float yRespawnValue;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y < yRespawnValue)
        {
            SceneManager.LoadScene("FPS Parkour");
        }

    }
}
