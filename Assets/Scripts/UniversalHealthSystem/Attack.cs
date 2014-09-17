using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public Health health;
	public int AttackStrength;

	void Start () 
	{
		health = GetComponent<Health>();
		AttackStrength = 20;
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			health.Damage(AttackStrength);
	}
}
