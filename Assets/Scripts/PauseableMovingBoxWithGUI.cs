using UnityEngine;
using System.Collections;

public class PauseableMovingBoxWithGUI : MonoBehaviour 
{
	[SerializeField]
	float speed = 5f;

	bool isPaused;

	float guiBoxWidth = 200f;
	float guiBoxHeight = 200f;
	float guiBoxX;
	float guiBoxY;
	float buttonWidth = 150f;
	float buttonHeight = 20f;
	 

	void Awake()
	{
		guiBoxX = Screen.width / 2 - guiBoxWidth / 2;
		guiBoxY = Screen.height / 2 - guiBoxHeight / 2;
	}

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
			isPaused = true;
			Time.timeScale = 0;
		}
		else if(Time.timeScale == 0)
		{
			Debug.Log ("Game is unpaused");
			isPaused = false;
			Time.timeScale = 1;
		}
	}

	void OnGUI()
	{
		if(isPaused)
		{
			GUI.Box(new Rect(guiBoxX, guiBoxY, guiBoxWidth, guiBoxHeight), "Paused");
			if(GUI.Button(new Rect(guiBoxX + buttonWidth / 6, guiBoxY + buttonHeight * 1.5f, buttonWidth, buttonHeight), "Unpause"))
			{
				Debug.Log ("Game is unpaused");
				isPaused = false;
				Time.timeScale = 1;
			}
				
		}
	}

}








