using UnityEngine;
using System.Collections;

// States of the Menu
enum menuStates
{
	IsRunning,
	Main,
	Options,
	NewGame,
	LoadGame
	// Exit
}

public abstract class Screen : MonoBehaviour
{

	// To change Screens
	protected int running;

	public int isRunning {
		get {
			return running;
		}
		set {
			running = value;
		}
	}

	// Check If Screens have changed
	abstract public int status ();

	// Update is called once per frame
	abstract public void Update ();

	// Updates GUI
	abstract public void OnGUI ();

}
