using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public InventoryStats inventoryStats;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inventoryStats.Coins += 1; // Suma 1 moneda
            gameObject.SetActive(false); // Desactiva la moneda
        }
    }
}
