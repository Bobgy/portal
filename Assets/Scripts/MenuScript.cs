﻿using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    void Start()
    {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
    }

	void OnGUI() {
		const int buttonWidth = 84;
		const int buttonHeight = 30;
		Rect StartButton = new Rect(30, Screen.height - 120, buttonWidth, buttonHeight);
		Rect ExitButton = new Rect(30, Screen.height - 80, buttonWidth, buttonHeight);
		Rect AboutButton = new Rect(30, Screen.height - 40, buttonWidth, buttonHeight);
		if (GUI.Button(StartButton, "START")) {
			Application.LoadLevel("demo2");
		}
		if (GUI.Button(ExitButton, "EXIT")) {
			Application.Quit();
		}
		if (GUI.Button(AboutButton, "ABOUT")) {
			Application.LoadLevel("about");
		}
	}
}