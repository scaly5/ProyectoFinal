using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        // Buscar todos los objetos con el tag "music"
        GameObject[] musicObjects = GameObject.FindGameObjectsWithTag("music");

        // Si ya existe otro objeto con el mismo tag, destruir este para evitar duplicados
        if (musicObjects.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        // Hacer que este objeto no se destruya al cambiar de escena
        DontDestroyOnLoad(gameObject);
    }
}