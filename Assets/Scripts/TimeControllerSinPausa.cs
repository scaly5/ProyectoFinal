using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;//llamamos a su biblioteca

public class TimeController : MonoBehaviour
{
    public GameObject menuPausa;
    public float scaleAtRuntime;

    public void HandleTime()
    {
        if (Time.timeScale != 0)
        {
            Pause();
        }
        else
        {
            Resume();
        }

    }
    public void Pause()
    {
        scaleAtRuntime = Time.timeScale;
        Time.timeScale = 0;
        menuPausa.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null); //deselecciona el boton aunque le hayamos hecho click
    }
    public void Resume()
    {
        Time.timeScale = scaleAtRuntime;
        menuPausa.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);//deselecciona el boton aunque le hayamos hecho click
    }

}

