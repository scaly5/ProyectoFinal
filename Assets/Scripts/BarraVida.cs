using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Image barraDeVida;
    public PlayerStats playerStats;
    public GameObject player;

    void Start()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            if (playerStats == null)
                playerStats = player.GetComponent<PlayerStats>();
        }
    }

    void Update()
    {
        if (player != null && barraDeVida != null && playerStats != null)
        {
            var controller = player.GetComponent<PlayerController>();
            if (controller != null)
            {
                barraDeVida.fillAmount = controller.Life / playerStats.MaxLife;
            }
        }
    }
}