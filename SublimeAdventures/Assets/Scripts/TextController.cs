using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TextController : MonoBehaviour {

	public Text text;
	public enum locations {
		mainmenu, entry_room_0, door_locked, corridor, drawer_open, sword_ex,
		key_pickup, entry_room_1, sword_pickup, entry_room_2, dead, corridor_Window_1, corridor_room_0, corridor_door_ex
		
	};
	public static locations myLocation;
	public static System.Random Attack = new System.Random();
	public static int HandAttack = Attack.Next(0, 30);
	public static int SwordBattle = Attack.Next(0, 100);
	public static int EnemyAttack = Attack.Next(0, 100);
	public static int damage;
	public Image logo;
	public Image dead;

	// Use this for initialization
	void Start () {
		myLocation = locations.mainmenu;

	}
	
	// Update is called once per frame
	void Update () {
		print (myLocation);

		if (Input.GetKeyDown (KeyCode.Q)) {
			Application.Quit ();
		}

		if (health.currentHealth <= 0) {
			myLocation = locations.dead;
		}

		if (myLocation == locations.corridor_Window_1) {
			
			corridor_window_ex();
		}
		if (myLocation == locations.corridor_door_ex) {
			
			corridor_door_ex();
		}

		if (myLocation == locations.dead) {
			
			dead_menu();
		}

		if (myLocation == locations.mainmenu) {

			mainmenu();
		}
		if (myLocation == locations.entry_room_0) {
			entry_room_0();
		}
		if (myLocation == locations.entry_room_1) {
			entry_room_1();
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
		if (myLocation == locations.sword_pickup) {
			sword_pickup();
		}
		if (myLocation == locations.key_pickup) {
			key_pickup();
		}
		if (myLocation == locations.entry_room_2) {
			entry_room_2();
		}
	}
	
	void mainmenu(){
		health.damage = 0;
		health.currentHealth = 100;
		enemyhealth.damage = 0;
		enemyhealth.currentHealth = 100;
		inventory.inventories.Clear();

		text.text = "Hello, welcom to the worlds best adventure game.\n" +
			"Are you ready to begin?\n\n" +
			"Press Any Key To continue";


		if (Input.anyKeyDown) {
			myLocation = locations.entry_room_0;
		}

	}

	void entry_room_0(){
		text.text = "You Awaken in a strange room, looking around you see a few things... " +
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

	void entry_room_1(){
		text.text = "Looking around you see a few things... " +
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
			
			myLocation = locations.entry_room_0;
			
		}
	}

	void corridor(){
		text.text = "When you exit the room you find yourself in a dark corridor, there is not much to see here.\n " +
			"on one wall there is a door, on the other side a Window, and straight in front of you the Ccrridor just continues into blackness." +
			
			"\nWhere would you like to go?\n\nPress W to examine the Window, Enter to continue down the corridor, or D to examine the door.";

		if (Input.GetKeyDown (KeyCode.W)) {
			myLocation = locations.corridor_Window_1;
		}
		if (Input.GetKeyDown(KeyCode.D)) {
			myLocation = locations.corridor_door_ex;
		}
	}

	void drawer_open(){

		text.text = "You Open the drawer, in the drawer you find a Key\n\n " +
			"Press K to take the key, Press ESC to close the drawer and return to the room.";

		if (Input.GetKeyDown (KeyCode.K)) {
			myLocation = locations.key_pickup;
		}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			myLocation = locations.entry_room_0;
		}
	}

	void sword_ex(){
		text.text = "You take a look at the sword, \n\n " +

			"It has a jewel in the Pommel, made of a tough iron, looks to be worth some money. \n " +
			"But it could also be a great weapon\n Press Enter to take the sword, Press ESC to leave the sword there.";

		if (Input.GetKeyDown(KeyCode.Return)) {
			myLocation = locations.sword_pickup;
		}

		if (Input.GetKeyDown(KeyCode.Escape)) {
			myLocation = locations.entry_room_1;
		}
	}

	void sword_pickup(){
		text.text = "YOu take the sword, it is heavy in your hands, this will be good to hold on to.\n\n" +

			"Press ESC to return to the Room";
		if (Input.GetKeyDown(KeyCode.Escape)) {
			myLocation = locations.entry_room_2;
		}
	
	}

	void key_pickup(){
	
		text.text = "You picked up the Key... Wonder what this goes to. \n\n " +
			"Press Enter to continue";
		if (Input.GetKeyDown(KeyCode.Return)) {
			myLocation = locations.entry_room_1;
		}
	}

	void entry_room_2(){
		text.text = "Looking around you see a few things... " +
			"Next to the bed is a drawer, " +
				"and there is a door directly in front of you.\n\n\n " +
				"Press SD to look in the drawer, and Enter to Open the door";
		
		if (Input.GetKeyDown (KeyCode.D)) {
			myLocation = locations.drawer_open;
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

	void corridor_door_ex(){

		text.text = "The door is partway open, you can see a sliver of torch light coming from within, you listen for a second... " +
			"there are some strange noises. you are unsure of what they are\n\n" +
			
			"Enter to Enter the room, ESC to return to the corridor";
		if (Input.GetKeyDown(KeyCode.Return)) {
			myLocation = locations.corridor_room_0;
		}
	}

	void corridor_window_ex(){
		
		text.text = "";
	}

	void dead_menu(){
		dead.enabled = true;
		logo.enabled = false;
		text.text = "You were killed. Would you like to reset?\n\n" +
			"Space for restart or ESC to quit";

		if (Input.GetKeyDown(KeyCode.Space)) {
			myLocation = locations.mainmenu;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
		
	}
}
