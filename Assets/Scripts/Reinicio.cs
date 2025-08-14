using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Reinicio : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Se tocan");

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("nivel 1", LoadSceneMode.Single);
        }
    }
}