using UnityEngine;
using System.Collections;

public class CoroutineEnemySpawnManager : MonoBehaviour {

	[SerializeField]
	GameObject playerToSpawn;
	[SerializeField]
	float delayTime = 5f;


	void Start () 
	{
		StartCoroutine(EnemySpawn());
	}
	
	IEnumerator EnemySpawn()
	{
		while(true)
		{
			Instantiate(playerToSpawn, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(delayTime);
		}

	}

}
