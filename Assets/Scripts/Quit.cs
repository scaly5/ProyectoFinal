using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void GameQuit()
    {
        Application.Quit();
        Debug.Log("se me apaga");
    }
}