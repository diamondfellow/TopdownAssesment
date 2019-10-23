using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && DarkGem.darkgem1 == 0)
        {
            SceneManager.LoadScene("Dark");
        }
        else if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Nightmare");
        }
            
       
    }
}
