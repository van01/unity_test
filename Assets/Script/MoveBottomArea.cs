﻿using UnityEngine;
using System.Collections;

public class MoveBottomArea : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider)
	{
		Debug.Log (collider.name + " is Destroy");

		Destroy (collider.gameObject);
	}

}
