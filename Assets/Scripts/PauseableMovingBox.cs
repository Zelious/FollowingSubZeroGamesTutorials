using UnityEngine;
using System.Collections;

public class PauseableMovingBox : MonoBehaviour 
{
	[SerializeField]
	float speed = 5f;

	void Update()
	{
		transform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * speed);
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);

		if(Input.GetKeyDown(KeyCode.Space))
			Pause();
	}

	void Pause()
	{
		if(Time.timeScale == 1)
		{
			Debug.Log ("Game is paused");
			Time.timeScale = 0;
		}
		else if(Time.timeScale == 0)
		{
			Debug.Log ("Game is unpaused");
			Time.timeScale = 1;
		}
	}

}
