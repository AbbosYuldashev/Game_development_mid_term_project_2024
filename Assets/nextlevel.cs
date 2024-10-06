using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
 

    private void Start()
    {
       
        
    }
    public void StartGame()
    {
       SceneManager.LoadScene("level2");
    }
}
