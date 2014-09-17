using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int maxHealth;
	public int curHealth;
	public int minHealth;
	public GameObject player;
	
	void Start () 
	{
		player = GameObject.Find("Player");
		curHealth = maxHealth;
	}

	void Update () 
	{
		if(curHealth < minHealth)
			Destroy(player);
	}

	public void Damage(int damageAmount)
	{
		curHealth -= damageAmount;
	}
}
