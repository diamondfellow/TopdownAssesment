using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public static int rock = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(MainMenu.space == 1)
        {
            Destroy(gameObject);
            rock = 1;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
