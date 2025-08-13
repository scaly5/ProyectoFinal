using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ALosControles: MonoBehaviour
{
    public void constrols()
{
    SceneManager.LoadScene("Controles", LoadSceneMode.Single);
    
}
}
