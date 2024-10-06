using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opening : MonoBehaviour
{
   
    public void Close()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        
        SceneManager.LoadScene("leaderboard");
    }
}
