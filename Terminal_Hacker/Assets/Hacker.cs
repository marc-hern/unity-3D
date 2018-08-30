﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Game state
	int level;
	enum Screen {
		MainMenu,
		Password,
		Win
	};
	Screen currentScreen;

	// Passwords
	List<string> lvl1Passwords = new List<string>() {
		"password",
		"home",
		"123"
	};
	List<string> lvl2Passwords = new List<string>() {
		"pw123",
		"startupPW",
		"123!@#"
	};
	List<string> lvl3Passwords = new List<string>() {
		"Goog1!",
		"remote1!",
		"1!2@3#"
	};


	// Use this for initialization
	void Start() {
		ShowMainMenu();
	}

	void ShowMainMenu() {
		currentScreen = Screen.MainMenu;
		Terminal.ClearScreen();
		Terminal.WriteLine("Hack locations: ");
		Terminal.WriteLine("1.  Local");
		Terminal.WriteLine("2.  Startup");
		Terminal.WriteLine("3.  Google");
		Terminal.WriteLine("Enter selection:");
	}

	void OnUserInput(string input) {
		if (input.ToLower() == "menu") {
			ShowMainMenu();
		} else if (currentScreen == Screen.MainMenu){
			RunMainMenu(input);
		} else if (currentScreen == Screen.Password){
			CheckPassword(input);
		}
	}

	void RunMainMenu(string input){
		if (input == "1") {
			level = 1;
			StartGame();
		} else if (input == "2") {
			level = 2;
			StartGame();
		} else if (input == "3") {
			level = 3;
			StartGame();
		} else if (input == "007") {
			Terminal.WriteLine("Select a level Mr. Bond.");
			currentScreen = Screen.MainMenu;
		} else {
			Terminal.WriteLine("Invalid choice.");
			currentScreen = Screen.MainMenu;
		}
	}

	void StartGame(){
		currentScreen = Screen.Password;
		Terminal.WriteLine("Enter level " + level + " password:");
	}
	
	void CheckPassword(string input) {
		if (level == 1){
			if (lvl1Passwords.Contains(input)) {
				Terminal.WriteLine("I'm in...");
			}
			else {
				Terminal.WriteLine("Try again...");
			}
		} else if (level == 2){
			if (lvl2Passwords.Contains(input)) {
				Terminal.WriteLine("I'm in...");
			}
			else {
				Terminal.WriteLine("Try again...");
			}
		} else if (level == 3){
			if (lvl3Passwords.Contains(input)) {
				Terminal.WriteLine("I'm in...");
			}
			else {
				Terminal.WriteLine("Try again...");
			}
		}
	}
	// Update is called once per frame
	void Update() {
		
	}
}
