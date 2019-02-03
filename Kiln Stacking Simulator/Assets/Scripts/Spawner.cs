using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public List<GameObject> potteryPrefabs;
    public int respawnAfter = 1000;
    int timer = 0;

    public int respawnRange = 10;

    GameObject spawned;

	// Use this for initialization
	void Start () {
        spawned = Instantiate(potteryPrefabs[Random.Range(0, potteryPrefabs.Count)], transform);
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.childCount == 0 || Vector3.Distance(transform.position, spawned.transform.position) >= respawnRange)
        {
            timer++;
        }

        if(timer >= respawnAfter)
        {
            Start();

        }
	}
}
