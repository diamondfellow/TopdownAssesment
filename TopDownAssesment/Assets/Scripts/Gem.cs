using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gem : MonoBehaviour
{
    public static int darkgem1 = 0; 
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
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            darkgem1 = 1;
            //SceneManager.LoadScene("House");
        }
    }
}
