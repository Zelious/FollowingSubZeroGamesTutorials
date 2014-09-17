using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {

	float left, top, width, height;
	ASL asl;
	AnotherPlayer anotherPlayer;
	Child child;
	

	void Start () 
	{
		left = Screen.width / 9;
		top = Screen.height / 9;
		width = 400f;
		height = 400f;
		asl = GameObject.Find("ASL").GetComponent<ASL>();
		anotherPlayer = GameObject.Find("AnotherPlayer").GetComponent<AnotherPlayer>();
		child = GameObject.Find("Child").GetComponent<Child>();
	}

	void OnGUI()
	{
		GUI.BeginGroup(new Rect(left,top,width,height));
		GUILayout.Label("Name: " + GetComponent<Name>().name);
		GUILayout.Label("Age: " + asl.age);
		GUILayout.Label("Sex: " + asl.sex);
		GUILayout.Label("Location: " + asl.location);
		GUILayout.Label("Health: " + anotherPlayer.health);
		GUILayout.Label("Score: " + anotherPlayer.score);
		GUILayout.Label("In Child Object: " + child.childText);
		GUI.EndGroup();

	}
}
