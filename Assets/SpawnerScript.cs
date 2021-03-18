using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject[] spawners;
    public GameObject Soldier;
    float timeGoal;
    public float interval;
     
    // Start is called before the first frame update
    void Start()
    {
        timeGoal = Time.time + interval;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timeGoal){
            int random = Random.Range(0, spawners.Length);
            Debug.Log(random);
            var spawner = spawners[random];
            Instantiate(Soldier, spawner.transform.position, Quaternion.identity);
            timeGoal = Time.time + interval;
        }

    }
}
