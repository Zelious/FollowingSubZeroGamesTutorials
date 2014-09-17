using UnityEngine;
using System.Collections;

public class LayerMaskRayCast : MonoBehaviour {

	[SerializeField]
	float range;

	//int layerMaskNumber;
	public LayerMask emenyLayer;

	// Debug variables
	float dRayDuration;

	void Start()
	{
		dRayDuration = 5f;
		range = 500f;
		//layerMaskNumber = 1 << 8;	// This is called a "BitShift" 32 0s from right to left, stat at the bottom right 0 and go left 8 times for the layers.
		/* 
		 * What the above "BitShift" is doing:
		 * 0000 0000 0000 0000
		 * 0000 0000 1000 0000
		*/
	}

	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;

			// All of these RayCasts's layerMask are the same.
			//if(Physics.Raycast(rayOrigin, out hitInfo, range, layerMaskNumber | emenyLayer.value))
			//if(Physics.Raycast(rayOrigin, out hitInfo, range, layerMaskNumber))
			//
			if(Physics.Raycast(rayOrigin, out hitInfo, range, emenyLayer.value))
			{
				if(hitInfo.collider != null)
					hitInfo.transform.renderer.material.color = Color.blue;

				Debug.DrawRay(rayOrigin.origin, hitInfo.point, Color.red, dRayDuration);


			}
		}
	}
}
