using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name) {
		Debug.Log ("Level load requested for: " + name);
		Application.LoadLevel(name);
	}
	
	public void RestartRequest () {
		Debug.Log ("Restart Game");
		Application.LoadLevel("Start");
	}
	
	public void QuitRequest() {
		Debug.Log("Quit requested");
		Application.Quit ();
	}
}
