using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour {

	private float guiBoxWidth = 200f;
	private float guiBoxHeight = 200f;
	private float buttonWidth = 150f;
	private float buttonHeight = 20f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnGUI()
	{
		// Make a background for the button.
		GUI.Box(new Rect(Screen.width / 2 - guiBoxWidth / 2, Screen.height / 2 - guiBoxHeight / 2, guiBoxWidth, guiBoxHeight), "Content");

		// Make a button. 
		// Be able to click the button.
		// If they click itm return inventory screen.
		if(GUI.Button(new Rect(Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight * 3.5f, buttonWidth, buttonHeight), "Inventory"))
			Application.LoadLevel("Movement");


		//GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 40, 150, 20), "Level 1 is a Lie.");
	}
}
