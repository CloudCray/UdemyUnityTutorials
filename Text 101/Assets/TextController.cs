using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {
		cell, 
		mirror, 
		sheets_0, 
		door_0, 
		sheets_1, 
		door_1, 
		cell_mirror, 
		corridor_0
	}
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.cell) 		{cell();} 
		else if (myState == States.sheets_0) 	{sheets_0();} 
		else if (myState == States.door_0) 		{door_0();} 
		else if (myState == States.mirror) 		{mirror();} 
		else if (myState == States.cell_mirror) {cell_mirror();} 
		else if (myState == States.sheets_1) 	{sheets_1();} 
		else if (myState == States.door_1) 		{door_1();} 
		else if (myState == States.corridor_0) 	{corridor_0();}
	}
	
	void cell () {
		text.text = "You are in a prison cell, and you want to escape. " +
					"There are some dirty sheets on the bed, a mirror on the wall, " +
					"and the door is locked from the outside.\n\n" +
					"Press S to view Sheeets.\n" +
					"Press D to view Door.\n" +
					"Press M to view Mirror.";
		
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.door_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		}
	}
	void sheets_0 () {
		text.text = "You can't believe you sleep in these things. " +
					"Also, there's no way these things are long enough " +
					"to climb out of the window.\n\n" +
					"Press R to continue Roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	void door_0 () {
		text.text = "This is one of those button locks. You have no idea what the " +
					"combination is. You wish you could somehow see where the dirty " +
					"fingerprints were, maybe that would help.\n\n" +
					"Press R to continue Roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	void mirror () {
		text.text = "The dirty old mirror on the wall seems loose.\n\n" +
					"Press T to Take the mirror.\n" +
					"Press R to continue Roaming your cell.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}
	void cell_mirror () {
		text.text = "You are in a prison cell, and you STILL want to escape. " +
				"You are holding a mirror, there are some dirty sheets on the bed, " +
				"and the door is locked from the outside.\n\n" +
				"Press S to view Sheeets.\n" +
				"Press D to view Door.";
		
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.door_1;
		}
	}
	void sheets_1 () {
		text.text = "These sheets don't look any better through the mirror.\n\n" +
				"Press R to continue Roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	void door_1 () {
		text.text = "You reach your arrm through the bars, and you can read which " +
				"buttons have been pressed. Maybe you can try a few combinations?\n\n" +
				"Press O to Open the door\n" +
				"Press R to continue Roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		} else if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.corridor_0;
		}
	}
	void corridor_0 () {
		text.text = "You're free!\n\n" + 
	 			"Press P to Play again.";
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell;
		}
	}
}