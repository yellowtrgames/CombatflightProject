using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnasteroid : MonoBehaviour
{

    public Transform[] spawnpoints;
    public GameObject[] randomposition;
    public float  Startspawntime =10;
    public float spawntime = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating( "Spawn", Startspawntime, spawntime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int spawnpoints = Random.Range (0,3);
        int randomposition = Random.Range (0,6);

        Instantiate(this.randomposition[randomposition], this.spawnpoints[spawnpoints].position, this.spawnpoints[spawnpoints].rotation);
        
    }
}
