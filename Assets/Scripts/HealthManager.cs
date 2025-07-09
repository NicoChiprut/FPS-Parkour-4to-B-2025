using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public float health;
    public UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateHealth(float amount)
    {
        if (health - amount <= 0)
        {
            Debug.Log("Moriste");
            SceneManager.LoadScene("FPS Parkour");
            return false;
        }
        else
        {
            health -= amount;
            uiManager.UpdateHealthText(health.ToString());
            return true;
        }
    }
}