using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TextController : MonoBehaviour {

	public Text text;
	public enum locations {
		mainmenu, room_0, door_locked, corridor, drawer_open, sword_ex,
		key_pickup, room_1
		
	};
	public static locations myLocation;


	// Use this for initialization
	void Start () {
		myLocation = locations.mainmenu;

	}
	
	// Update is called once per frame
	void Update () {
		print (myLocation);
		if (myLocation == locations.mainmenu) {

			mainmenu();
		}
		if (myLocation == locations.room_0) {
			room_0();
		}
		if (myLocation == locations.room_1) {
			room_1();
		}
		if (myLocation == locations.door_locked) {
			door_locked();
		}
		if (myLocation == locations.corridor) {
			corridor();
		}
		if (myLocation == locations.drawer_open) {
			drawer_open();
		}
		if (myLocation == locations.sword_ex) {
			sword_ex();
		}
		if (myLocation == locations.key_pickup) {
			key_pickup();
		}
	}
	
	void mainmenu(){
		text.text = "Hello, welcom to the worlds best adventure game.\n" +
			"Are you ready to begin?\n\n" +
			"Press Any Key To continue";


		if (Input.anyKeyDown) {
			myLocation = locations.room_0;
		}



	}

	void room_0(){
		text.text = "You Awaken in a strange room, looking around you see a few things... " +
			"Leaning against a wall is a sword, next to the bed is a drawer, " +
			"and there is a door directly in front of you.\n\n\n " +
			"Press S to examine the sword, D to look in the drawer, and Enter to Open the door";

		if (Input.GetKeyDown (KeyCode.D)) {
			myLocation = locations.drawer_open;
		}

		if (Input.GetKeyDown (KeyCode.S)) {

		}

		if (Input.GetKeyDown (KeyCode.Return)) {


			if (!inventory.inventories.Contains("Key"))
			{
				myLocation = locations.door_locked;
			} else{
				myLocation = locations.corridor;
			}
			
		}
	}

	void room_1(){
		text.text = "Ylooking around you see a few things... " +
			"Leaning against a wall is a sword, next to the bed is a drawer, " +
				"and there is a door directly in front of you.\n\n\n " +
				"Press S to examine the sword, D to look in the drawer, and Enter to Open the door";
		
		if (Input.GetKeyDown (KeyCode.D)) {
			myLocation = locations.drawer_open;
		}
		
		if (Input.GetKeyDown (KeyCode.S)) {
			myLocation = locations.sword_ex;
		}
		
		if (Input.GetKeyDown (KeyCode.Return)) {
			
			
			if (!inventory.inventories.Contains("Key"))
			{
				myLocation = locations.door_locked;
			} else{
				myLocation = locations.corridor;
			}
			
		}
	}

	void door_locked(){
		text.text = "The door is locked. There must be a key here somewhere.\n\n\n" +
			"Press ESC to return to the room";

		if (Input.GetKeyDown (KeyCode.Escape)) {
			
			myLocation = locations.room_0;
			
		}
	}

	void corridor(){
		text.text = "";
		}

	void drawer_open(){
		text.text = "You Open the drawer, in the drawer you find a Key\n\n " +
			"Press K to take the key, Press ESC to close the drawer and return to the room.";

		if (Input.GetKeyDown (KeyCode.K)) {
			myLocation = locations.key_pickup;
		}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			myLocation = locations.room_0;
		}
	}

	void sword_ex(){
		text.text = "You take a look at the sword, ";

	}

	void key_pickup(){
	
		text.text = "You picked up the Key... Wonder what this goes to. \n\n " +
			"Press Enter to continue";
		if (Input.GetKeyDown(KeyCode.Return)) {
			myLocation = locations.room_1;
		}
	}

}
