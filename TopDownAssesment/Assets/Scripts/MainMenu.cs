using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static int space = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        if(PlayerPrefs.GetInt("win") == 0)
        {
            SceneManager.LoadScene("Level1");
        }
        else
        {
            //SceneManager.LoadScene("Level2");
            space = 1;
            SceneManager.LoadScene("Level1");
        }
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Secret()
    {
        SceneManager.LoadScene("Controls");
    }
    public void reset()
    {
        PlayerPrefs.SetInt("win", 0);
    }
}
