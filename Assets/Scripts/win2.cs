using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class Win2 : MonoBehaviour
{
    public GameObject win2Text; //panel nuevo
 public void OnTriggerEnter2D(Collider2D collider){
    Debug.Log("se tocan ");
    
    if(collider.gameObject.CompareTag("Player")){
    win2Text.SetActive(true);
    } // Panel nuevo
 }
}