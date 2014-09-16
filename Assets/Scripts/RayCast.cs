using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour 
{
	[SerializeField]
	private float attackRange = 25f;
	[SerializeField]
	private float attackImpact = 40f;
	[SerializeField]
	private Transform bulletHole;

	// Debug Variables
	[SerializeField]
	private float drawRayDuration = 1f;

	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime);
		
		// If Left mouse button is clicked, 
		// create a raycast that originates from the mouse clicked position.

		if(Input.GetMouseButtonDown(0))
		{
			Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;

			if(Physics.Raycast(rayOrigin, out hitInfo, attackRange))
			{
				Debug.Log ("You are casting as Ray");
				Debug.DrawRay(rayOrigin.direction, hitInfo.point, Color.red, drawRayDuration);


				if(hitInfo.rigidbody != null)
				{
					hitInfo.transform.renderer.material.color = Color.green;
					hitInfo.rigidbody.AddForceAtPosition(rayOrigin.direction * attackImpact, hitInfo.point);
					//Instantiate(bulletHole, hitInfo.point, Quaternion.Euler(270,0,0));
				}
			}
		}

	}
}
