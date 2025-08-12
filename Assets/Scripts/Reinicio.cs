using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reinicio : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Se tocan");
        if (collision.gameObject.CompareTag("Player"))
        {
           
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);  // Recarga la escena actual
        }
    }
}