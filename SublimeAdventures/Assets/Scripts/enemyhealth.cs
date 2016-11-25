using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class enemyhealth : MonoBehaviour {

	public Text enemyHealth;
	public static int startingHealth = 100;
	public static int damage;
	public static int currentHealth;
	public static string showHealth;
	// Use this for initialization
	void Start () {
		currentHealth = startingHealth-damage;
		showHealth = "Health: " + currentHealth.ToString ();
		enemyHealth.text = showHealth;
		enemyHealth.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (TextController.myLocation == TextController.locations.begin_battle) {
			enemyHealth.enabled = true;
		}
		currentHealth = startingHealth-damage;
		showHealth = "Enemy Health: " + currentHealth.ToString ();
		enemyHealth.text = showHealth;
	}
}
