using UnityEngine;
using System.Collections;

public class MainMenuStateMachine : MonoBehaviour
{

	// Current State
	private int menuState = (int)menuStates.Main;


	// Creates in instance of Screen
	Screen cScreen = new Screen_Main ();

	// Use this for initialization
	void Start ()
	{
	
	}

	// Update is called once per frame
	void Update ()
	{
		// Check what state the menu is in
		if (cScreen.status () != (int)menuStates.IsRunning) {
			menuState = cScreen.status ();

			switch (menuState) {
			
			case (int)menuStates.Main:
				cScreen = new Screen_Main ();
				break;

			case (int)menuStates.Options:
				cScreen = new Screen_Options ();
				break;

			case (int)menuStates.NewGame:
				cScreen = new Screen_NewGame ();
				break;

			case (int)menuStates.LoadGame:
				cScreen = new Screen_LoadGame ();
				break;

			default:
				Debug.Log ("cScreen State Unknown");
				break;
			}
		}

		// Update Current Screen
		cScreen.Update ();
	}

	// Updates on GUI
	void OnGUI ()
	{
		// Updates Current Screens GUI
		cScreen.OnGUI ();
	}
}
