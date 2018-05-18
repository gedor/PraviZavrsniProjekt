﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public Button exitGameButton;
	public Button resumeButton;
	public Button controlsButton;
	public Canvas pauseCanvas;

	public Canvas victoryCanvas;
	public Canvas trueVictoryCanvas;
	public Canvas deathCanvas;
	public Canvas controlsCanvas;
	// Use this for initialization
	void Start () {
		pauseCanvas.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (victoryCanvas.enabled == false && trueVictoryCanvas.enabled == false && deathCanvas.enabled == false) 
		{
			if (Input.GetKeyUp (KeyCode.Escape)) {

				if (pauseCanvas.enabled == false) {
			
					pauseCanvas.enabled = true;
					Time.timeScale = 0.0f;
				} else {
			
					pauseCanvas.enabled = false;
					Time.timeScale = 1.0f;
				}

			}

		}
	}
			public void ResumeGame(){
	
		pauseCanvas.enabled = false;
		Time.timeScale = 1.0f;
			}
			public void ExitGame(){
	
		Application.Quit ();
			}
	public void ControlsButton(){

		if (controlsCanvas.enabled == false) {

			controlsCanvas.enabled = true;
		}
	}
}