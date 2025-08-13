using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryStats : MonoBehaviour
{
    [Header("Texto UI")]
    public TextMeshProUGUI monedastxt;

    public int Coins = 0;

    void Update()
    {
        if (monedastxt != null)
        {
            monedastxt.text = "GoatCoin: " + Coins.ToString();
        }
        else
        {
            Debug.LogWarning("monedastxt no esta asignado en el Inspector.");
        }
    }
}