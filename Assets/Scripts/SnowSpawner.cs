using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSpawner : MonoBehaviour {

    [SerializeField] private GameObject snowflake;
    [SerializeField] private float spawnsPerSecond;

    private Vector3 spawnPosition;
    private float halfWidth;
    private float spawnCoeff;
    private float spawnTimer;

	void Start () {
        spawnPosition = transform.position;
        halfWidth = GetComponent<Renderer>().bounds.extents.x;
        spawnCoeff = 1.0f / spawnsPerSecond;
        spawnTimer = spawnCoeff;
        
	}
	
	void Update () {
		if(spawnTimer <= 0.0f)
        {
            spawnPosition.x = Random.Range(transform.position.x - halfWidth, transform.position.x + halfWidth);
            Instantiate(snowflake, spawnPosition, Quaternion.identity);
            spawnTimer = spawnCoeff;
        }
        else
        {
            spawnTimer -= Time.deltaTime;
        }
	}
}
