using UnityEngine;
using System.Collections;

public class EnemySpawnManager : MonoBehaviour {

	[SerializeField]
	GameObject enemyToSpawn;
	[SerializeField]
	float delaySpawn;

	float canSpawn;

	void Start () 
	{
		delaySpawn = 5.0f;
		canSpawn = -1;
	}
	

	void Update () 
	{
		if(Time.time >= canSpawn)
		{
			Instantiate(enemyToSpawn);
			canSpawn = Time.time + delaySpawn;
		}

	}
	
}
