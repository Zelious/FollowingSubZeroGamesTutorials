using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	[SerializeField]
	private float playerSpeed = 5.0f;

	// Use this for initialization
	void Start () 
	{
		// Player spawn point

		// This is where our player will start when the game is played
		transform.position = new Vector3(0,3,0);

	}
	
	// Update is called once per frame
	void Update () 
	{
		// Player to move left, right, up , down
		// player (gameobject aka transform to move when I press the arrow keys.
		/*
		if(Input.GetKey(KeyCode.W))
			transform.Translate(Vector3.up * Time.deltaTime);
		if(Input.GetKey(KeyCode.A))
			transform.Translate(Vector3.left * Time.deltaTime);
		if(Input.GetKey(KeyCode.S))
			transform.Translate(Vector3.down * Time.deltaTime);
		if(Input.GetKey(KeyCode.D))
			transform.Translate(Vector3.right * Time.deltaTime);
		*/

		transform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed);
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed);
	}
}
