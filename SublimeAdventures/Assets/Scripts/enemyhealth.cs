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
	// Use this for initialization
	void Start () {
		enemyHealth.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
