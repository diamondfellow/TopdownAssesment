using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    Vector3 spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = transform.position;
        spawn = GateTriiger.enemyspawn; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Teleport()
    {
        transform.position = spawn;
    }
}
