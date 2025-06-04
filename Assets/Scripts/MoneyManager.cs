using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;

    public void UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            //impedir la compra
            Debug.Log("Dinero insuficiente");
        }
        else
        {
            money += amount;
        }
    }
}
