using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class health : MonoBehaviour {

	public Text myHealth;
	public static int startingHealth = 100;
	public static int damage;
	public static int currentHealth;
	public static string showHealth;


	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
		showHealth = "Health: " + currentHealth.ToString ();
		myHealth.text = showHealth;

	}
	
	// Update is called once per frame
	void Update () {
		currentHealth = startingHealth-damage;
		showHealth = "Health: " + currentHealth.ToString ();
		myHealth.text = showHealth;
	}
}
