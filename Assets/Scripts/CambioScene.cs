using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CambioNivel3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Se tocan");

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("nivel 3", LoadSceneMode.Single);
        }
    }
}
