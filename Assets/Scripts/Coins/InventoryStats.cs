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
        monedastxt.text = "GoatCoin: " + Coins.ToString();
    }
}