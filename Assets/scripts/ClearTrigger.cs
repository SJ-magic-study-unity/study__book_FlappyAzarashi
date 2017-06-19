using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTrigger : MonoBehaviour {
	GameObject gameController;
	
	// Use this for initialization
	void Start () {
		gameController = GameObject.FindWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerExit2D(Collider2D other){
		gameController.SendMessage("IncreaseScore");
	}
}
