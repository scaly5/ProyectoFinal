using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneM: MonoBehaviour
{
    public void play()
{
    SceneManager.LoadScene("nivel 1", LoadSceneMode.Single);
    
}

    public void menu()
{
    SceneManager.LoadScene("MENU", LoadSceneMode.Single);
}
    public void nivel2()
{
    SceneManager.LoadScene("NIVEL 2", LoadSceneMode.Single);
}
    public void creditos()
{
    SceneManager.LoadScene("creditos2", LoadSceneMode.Single);
}
}
