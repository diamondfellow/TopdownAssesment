using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedWin : MonoBehaviour
{
    public int win = 0;
    // Start is called before the first frame update
    void Start()
    {
        win = PlayerPrefs.GetInt("win");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Win");
            PlayerPrefs.SetInt("win", 1);
        }
       
    }
}
