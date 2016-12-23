using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// An enum (enumeration) is a type that consists of a set of constants called the enumerator list
// To connect text, drag object from hierarchy to the inspector pane

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0,
						floor, closet_door, window_0, jump_out, choose_stairs_0, corridor_1, hairclip, stairs_1,
						in_closet, corridor_2, corridor_3, dress, mysterious_cell, unlock_cell, no_unlock_cell,
						courtyard, freedom};
	private States myState;
	private bool found_hairclip = false;
	private bool dress_cleaner = false;
	private bool inCloset = false;
	private bool backToInCloset = false;
	private bool visitedCell = false;
	private bool restart = false;
	private int hairflag, mirrorflag;

	// Use this for initialization
	void Start () {

		// Set the initial state (cell)
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		
		// If the state is a certain state, then call that state's function
		if (myState == States.cell)
			cell ();
		else if (myState == States.sheets_0)
			sheets_0 ();
		else if (myState == States.lock_0)
			lock_0 ();
		else if (myState == States.cell_mirror)
			cell_mirror ();
		else if (myState == States.mirror && mirrorflag == 1)
			mirror2 ();
		else if (myState == States.mirror)
			mirror ();
		else if (myState == States.sheets_1)
			sheets_1 ();
		else if (myState == States.lock_1)
			lock_1 ();
		else if (myState == States.corridor_0)
			corridor_0 ();
		else if (myState == States.stairs_0)
			stairs_0 ();
		else if (hairflag == 1 && myState == States.floor)
			floor2 ();
		else if (myState == States.floor)
			floor ();
		else if (myState == States.closet_door)
			closet_door ();
		else if (myState == States.window_0)
			window_0 ();
		else if (myState == States.jump_out)
			jump_out ();
		else if (myState == States.choose_stairs_0)
			choose_stairs_0 ();
		else if (myState == States.hairclip)
			hairclip ();
		else if (myState == States.corridor_1)
			corridor_1 ();
		else if (myState == States.stairs_1)
			stairs_1 ();
		else if (myState == States.in_closet)
			in_closet ();
		else if (myState == States.corridor_2)
			corridor2 ();
		else if (myState == States.corridor_3)
			corridor3 ();
		else if (myState == States.dress)
			dress ();
		else if (myState == States.mysterious_cell)
			mysteriousCell ();
		else if (myState == States.unlock_cell)
			unlockCell ();
		else if (myState == States.no_unlock_cell)
			noUnlockCell ();
		else if (myState == States.courtyard)
			courtyard ();
		else if (myState == States.freedom)
			freedom ();
	}

	#region State methods
	// States - store into an enum, one method per state
	void cell() {
		if (restart) {
			found_hairclip = false;
			dress_cleaner = false;
			inCloset = false;
			backToInCloset = false;
			visitedCell = false;
			restart = false;
			hairflag = 0;
			mirrorflag = 0;
		}
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and the door " +
					"is locked from the outside.\n\n" +
					"Press S to view Sheets, M to view Mirror and L to view Lock";
		if(Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		}
		if(Input.GetKeyDown(KeyCode.L)) {
			if(mirrorflag == 1)
				myState = States.lock_1;
			else
				myState = States.lock_0;
		}
		if(Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		}
	}
	void sheets_0() {
		text.text = "You can't believe you've slept in those sheets all of those years. " +
		"They don't even change them! Oh well, the luxury of prison life I guess.\n\n" +
		"Press R to return to roaming your cell.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	void lock_0() {
		text.text = "This is one of the button locks. You have no idea what the combination is. " +
		"You wish you can somehow see where the dirty fingerprints are, maybe that would help.\n\n" +
		"Press R to return to roaming your cell";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	void mirror() {
		text.text = "You see an extremely dirty mirror. You wonder, it could be useful for something. You're not " +
		"sure though, after all, it's only a mirror...\n\n" +
		"Press R to return to roaming your cell, or T to take the mirror";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
		else if(Input.GetKeyDown(KeyCode.T)) {
			myState = States.cell_mirror;
			mirrorflag += 1;
		}
	}
	void mirror2() {
		text.text = "You already took the mirror! It's in your hand. \n\n" +
		"Press R to return to roaming your cell";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	void cell_mirror() {
		text.text = "You have acquired a mirror!\n\n Press R to return to roaming your cell";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	void sheets_1() {
		text.text = "You look at the sheets again. Still can't believe that you've slept soundly in these sheets. " +
		"Maybe after you leave, someone will clean them someday. The mirror doesn't help make it look better either.\n\n" +
		"Press R to return to your cell";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	void lock_1() {
		text.text = "You carefully put the mirror between the bars, and turn it around " +
		"so you can see the lock. You can just make out fingerprints on the dirty buttons. " +
		"You press the dirty buttons, then hear a click.\n\n" +
		"Press O to open, or R to return to your cell";
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.corridor_0;
		}
		else if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	void corridor_0() {
		text.text = "You are now in a corridor. There are two stairwells up ahead and a closet to your right. " +
		"You're getting anxious, you don't have much time left. What do you do? \n\n" +
		"Press S to go up the Stairs, F to search the floor and C to search the closet";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.choose_stairs_0;
		}
		else if(Input.GetKeyDown(KeyCode.F)) {
			myState = States.floor;
		}
		else if(Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_door;
		}
	}
	void stairs_0() {
		text.text = "The door is unlocked! You go up the stairs, but unfortunately, it's a dead end. There is only a window, and " +
		"it is a beautiful day outside.\n\n" +
		"Press R to return to the corridor, O to open the window";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
		else if(Input.GetKeyDown(KeyCode.O)) {
			myState = States.window_0;
		}
	}
	void window_0() {
		text.text = "The breeze caresses your skin, and the sun brings warmth into the stairway. How can it be " +
		"so serene out there, but so dark in here?\n\n" +
		"Press J to jump out the window, R to return to the stairway";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.stairs_0;
		}
		else if(Input.GetKeyDown(KeyCode.J)) {
			myState = States.jump_out;
		}
	}
	void jump_out() {
		text.text = "You jumped out the window, flying like a baby bird's first flight. Unfortunately, you died. " +
		"You escaped prison, but lost your life in the process. Better be more careful next time! \n\n" +
		"Press P to play again";
		if(Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell;
			restart = true;
		}
	}
	void choose_stairs_0() {
		text.text = "Do you want to go up the right or left stairwell? \n\n" +
		"Press L for Left or R for Right, B to go back to the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_1;
		}
		else if(Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_0;
		}
		else if(Input.GetKeyDown(KeyCode.B)) {
			myState = States.corridor_0;
		}
	}
	void floor() {
		text.text = "You desperately search around for anything, anything that can be helpful. " +
		"Fortunately, you found a hairclip! Maybe this would work. \n\n" +
		"Press H to pick up the Hairclip, R to return to the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		} else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.hairclip;
			hairflag += 1;
		}
		found_hairclip = true;
	}
	void floor2() {
		text.text = "There's nothing here.\n\n" +
			"Press R to continue roaming the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
	void hairclip() {
		text.text = "You have acquired a hairclip! It looks a bit rusty but it'll do. Hairclips do have a lot of " +
		"handy uses.\n\n" +
		"Press R to return to the corridor";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
	void closet_door() {
		text.text = "Nothing in here, not even clothes. You wish you had new clothes to change into, since the " +
		"ones you're wearing right now are disgusting.\n\n" +
		"Press R to return to the corridor";
		if(Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
	void corridor_1() {
		if(found_hairclip) {
			text.text = "You insert the hairclip into the lock and hear a click. The door creaks open, revealing " +
			"another corridor with a stairwell and a closet. What do you do? \n\n" +
				"Press S to go to the Stairs, or C to open the closet. ";
			if (Input.GetKeyDown (KeyCode.S)) {
				myState = States.stairs_1;
			}
			else if(Input.GetKeyDown(KeyCode.C)) {
				myState = States.in_closet;
			}
		}
		else {
			text.text = "The door is locked! You can't get through.\n\n" +
				"Press R to return to the corridor";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.corridor_0;
			}
		}
		if(inCloset) {
			text.text = "You're back in the second corridor, with a stairwell and a closet. What do you do? \n\n" +
			"Press S to go to the Stairs, or C to open the closet. ";
			if (Input.GetKeyDown (KeyCode.S)) {
				myState = States.stairs_1;
			}
			else if(Input.GetKeyDown(KeyCode.C)) {
				myState = States.in_closet;
			}
		}
	}
	void stairs_1() {
		if(dress_cleaner) {
			text.text = "You see a guard, but thanks to the cleaner uniform, he ignores you. You go up the stairs, " +
			"but unfortunately, it's another dead end.\n\n " +
			"Press R to return to the corridor";
			if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.corridor_1;
			}
		}
		else {
			text.text = "You see a guard, and he recognizes you as one of the prisoners. He takes out his gun and " +
			"shoots you three times in the head. You're dead :(\n\n" +
			"Press P to Play Again";
			if (Input.GetKeyDown (KeyCode.P)) {
				myState = States.cell;
				restart = true;
			}
		}
	}
	void in_closet() {
		if (dress_cleaner) {
			text.text = "You are back at the fork. One corridor on the left and one on the right.\n\n" +
			"Press L to go to the Left corridor, R to go to the Right corridor, B to go to the previous corridor";
			if (Input.GetKeyDown (KeyCode.L)) {
				myState = States.corridor_2;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.corridor_3;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				myState = States.corridor_1;
				inCloset = true;
			}
		} else {
			if (backToInCloset) {
				text.text = "You are back at the fork. One corridor on the left, one on the right, and a cleaner's uniform.\n\n" +
				"Press L to go to the Left corridor, R to go to the Right corridor, D to Dress up as a cleaner, B to go back";
				if (Input.GetKeyDown (KeyCode.L)) {
					myState = States.corridor_2;
				} else if (Input.GetKeyDown (KeyCode.R)) {
					myState = States.corridor_3;
				} else if (Input.GetKeyDown (KeyCode.D)) {
					myState = States.dress;
					dress_cleaner = true;
				} else if (Input.GetKeyDown (KeyCode.B)) {
					myState = States.corridor_1;
					inCloset = true;
				}
			} else {
				text.text = "Is this Narnia??? There are two hidden corridors here, one forking off to the left, one to the " +
				"right. There's also a cleaner's uniform. What will you do?\n\n" +
				"Press L to go to the Left corridor, R to go to the Right corridor, D to Dress up as a cleaner, B to go back";
				if (Input.GetKeyDown (KeyCode.L)) {
					myState = States.corridor_2;
				} else if (Input.GetKeyDown (KeyCode.R)) {
					myState = States.corridor_3;
				} else if (Input.GetKeyDown (KeyCode.D)) {
					myState = States.dress;
					dress_cleaner = true;
				} else if (Input.GetKeyDown (KeyCode.B)) {
					myState = States.corridor_1;
					inCloset = true;
				}
			}
		}
	}
	void dress() {
		text.text = "You put on the cleaner's clothes, and they fit perfectly! They smell great too, freshly washed.\n\n" +
		"Press R to return to the fork.";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.in_closet;
		}
	}
	void corridor2() {
		if (visitedCell) {
			text.text = "You're back in the left corridor. This corridor is empty, expect for one cell at the end of the corridor.\n\n" +
			"Press G to Go to the cell or R to go back";
			if (Input.GetKeyDown (KeyCode.G)) {
				myState = States.mysterious_cell;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.in_closet;
				backToInCloset = true;
			}
		} else {
			text.text = "You enter the left corridor. This corridor is empty, expect for one cell at the end of the corridor.\n\n" +
			"Press G to Go to the cell or R to go back";
			if (Input.GetKeyDown (KeyCode.G)) {
				myState = States.mysterious_cell;
			} else if (Input.GetKeyDown (KeyCode.R)) {
				myState = States.in_closet;
				backToInCloset = true;
			}
		}
	}
	void mysteriousCell() {
		text.text = "There's a man here! He looks like he's suffering. Use the hairclip and open the cell to help him?\n\n" +
		"Y (Yes)\n" +
		"N (No)\n" +
		"R (Go back to the corridor)";
		if (Input.GetKeyDown (KeyCode.Y)) {
			myState = States.unlock_cell;
		} else if (Input.GetKeyDown (KeyCode.N)) {
			myState = States.no_unlock_cell;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		}
	}
	void unlockCell() {
		text.text = "Unfortunately, this man is crazy, but it was too late. He killed you with a shiv he had hidden " +
		"under his jumpsuit. You are dead.\n\n" +
		"Press P to Play Again.";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
			restart = true;
		}
	}
	void noUnlockCell() {
		text.text = "You refused to help this man. He seemed a bit out of his mind anyways.\n\n" +
				"Press R to go back to the corridor";
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
			visitedCell = true;
		}
	}
	void corridor3() {
		text.text = "You entered a corridor. It has a set of stairs that lead into a light! What do you do?\n\n" +
		"Press S to go up the Stairs or R to go back";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.courtyard;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.in_closet;
		}
	}
	void courtyard() {
		text.text = "The courtyard is eerily quiet. What's going on??? No guards or anything in sight... This " +
		"slightly unsettles you. But, you see the gate to leave the prison across the courtyard!\n\n" +
		"Press G to open the gate or R to return back to the corridor";
		if (Input.GetKeyDown (KeyCode.G)) {
			myState = States.freedom;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.in_closet;
		}
	}
	void freedom() {
		text.text = "Congratulations! You have escaped!\nTo be continued...\n\n" +
		"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
			restart = true;
		}
	}
	#endregion
}
