using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTriiger : MonoBehaviour
{
    
    public Transform player;
    float timer = 0f;
    public static bool spawnenemy = false;
    public static Vector3 enemyspawn;
    public static bool go = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1.5 && spawnenemy)
        {
              enemyspawn = new Vector3(player.position.x, player.position.y + 3, player.position.z);
            //EnemySpawn.Teleport();
            spawnenemy = false;
        }
    }
     void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            timer = 0f;
            spawnenemy = true;
        }
    }
}
