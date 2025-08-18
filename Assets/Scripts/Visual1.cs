using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Visual1: MonoBehaviour
{
    public void visual()
{
    SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
    
}

}
