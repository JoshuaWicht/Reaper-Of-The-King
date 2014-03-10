using UnityEngine;
using System.Collections;

public class Screen_LoadGame : Screen
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
		
	}

}
