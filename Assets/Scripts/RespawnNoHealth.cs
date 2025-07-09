using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnNoHealth : MonoBehaviour
{
    public HealthManager healthManager;
    public float yRespawnValue;
    public float fallDamage = 1000f; // Un valor lo suficientemente alto para "matar" al caer

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void Update()
    {
        if (transform.position.y < yRespawnValue)
        {
            healthManager.UpdateHealth(-fallDamage);
        }
    }
}