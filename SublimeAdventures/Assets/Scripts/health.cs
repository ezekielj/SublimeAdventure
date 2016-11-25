using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class health : MonoBehaviour {

	public Text myHealth;
	public static string theHealth = "100";
	// Use this for initialization
	void Start () {
		myHealth.text = theHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
