using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class inventory : MonoBehaviour {
	
	public static List<string> inventories = new List<string>();
	public Text myInventory;
	public Text Hola;
	// Use this for initialization
	void Start () {
		//GameObject theLocation = GameObject.Find("locations");
		//TextController Location1 = theLocation.GetComponent<TextController>();
		String_Builder ();
	}
	
	// Update is called once per frame
	void Update () {
		if (TextController.myLocation == TextController.locations.key_pickup) {

			if (!inventories.Contains("Key")) {
				inventories.Add ("Key");
			}
			String_Builder ();
		}
		if (TextController.myLocation == TextController.locations.room_0) {
			
			String_Builder();
			
		}
		if (TextController.myLocation == TextController.locations.sword_pickup) {

			if (!inventories.Contains("Sword")) {
				inventories.Add ("Sword");
			}
			String_Builder();
			
		}
	}
	
	void String_Builder(){
		StringBuilder builder = new StringBuilder();
		foreach (string item in inventories) // Loop through all strings
		{
			builder.Append(item).Append("|"); // Append string to StringBuilder
		}
		string result = builder.ToString();
		myInventory.text = result;
		print (result);
	}
}
