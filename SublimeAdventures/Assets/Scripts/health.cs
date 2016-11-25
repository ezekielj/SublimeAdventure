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
	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
		myHealth.text = currentHealth.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		currentHealth = startingHealth-damage;
		myHealth.text = currentHealth.ToString ();
	}
}
