using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public GameObject prefab;
    public Transform spawnpoint;

    
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(prefab, spawnpoint.position, spawnpoint.rotation);
    }
}
