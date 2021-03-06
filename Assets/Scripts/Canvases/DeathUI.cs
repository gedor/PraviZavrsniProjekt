﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathUI : MonoBehaviour {


	private PlayerHealthManager pla;
	public Canvas deathCanvas;

	public Button exitGam;

	
	
	private bool buttonSelected;
	// Use this for initialization
	void Start () {
		pla = GameObject.FindWithTag("Player").GetComponent<PlayerHealthManager> ();
		deathCanvas.enabled = false;
		exitGam.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (pla.dying == true) {
			StartCoroutine ("plaDead");
		
		}
		
	}
			public void ExitGame(){

				Application.Quit ();

			}
	public IEnumerator plaDead(){
	
		yield return new WaitForSeconds (1.0f);
		deathCanvas.enabled = true;
		exitGam.interactable = true;
		exitGam.Select();
	}

}
