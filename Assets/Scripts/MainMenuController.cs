using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame() 
    { 
        Debug.Log("Created by Meuti Zari A - 149251970100-171");
        SceneManager.LoadScene("Game"); 
    } 

    public void OpenAuthor() 
    { 
        Debug.Log("Created By Gue"); 
    } 

}
