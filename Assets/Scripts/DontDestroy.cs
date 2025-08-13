using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        // Buscar todos los objetos con el mismo tipo de componente (DontDestroy)
        DontDestroy[] instances = FindObjectsOfType<DontDestroy>();

        // Si ya hay otra instancia distinta de esta, destruir este objeto
        if (instances.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        // Hacer que este objeto no se destruya al cambiar de escena
        DontDestroyOnLoad(gameObject);
    }
}