using UnityEngine;
using System.Collections;

public class Screen_Options : Screen
{

	// Use this for initialization
	void Start ()
	{
		running = (int)menuStates.IsRunning;
	}
	
	// Check If Screens have changed
	public override int status ()
	{
		return running;
	}
	
	// Update is called once per frame
	public override void Update ()
	{
		
	}
	
	// Updates GUI
	public override void OnGUI ()
	{
		// Example of going back to main menu
		if (GUI.Button (new Rect (100, 100, 100, 100), "Back")) {
			running = (int)menuStates.Main;
		}
	}

}
