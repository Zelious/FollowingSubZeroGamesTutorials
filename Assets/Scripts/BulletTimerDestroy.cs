using UnityEngine;
using System.Collections;

public class BulletTimerDestroy : MonoBehaviour {

	int removeTime = 5;

	void Update()
	{
		Destroy(this.gameObject, 5f);
	}
	

}
