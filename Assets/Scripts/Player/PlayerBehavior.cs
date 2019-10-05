using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	//Variables for movement
	public float MaxSpeed = 5f;

	//Variable for Animator
	private Animator playerAnim;

	//Gamanager access
	private GameManager manager;

	// Use this for initialization
	void Start () {
		playerAnim = GetComponent<Animator>();
		manager = GameObject.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)){
			playerAnim.SetBool("isSwimming", true);
		}
		else {
			playerAnim.SetBool("isSwimming", false);
		}

	}
}
