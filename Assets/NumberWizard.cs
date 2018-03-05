using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int guess;

	public int max = 1000;
	public int min = 1;
	public int MaximumGuesses = 10;
	public Text text;

	// Use this for initialization
	void Start () {
		NextGuess();
	}
	
	void StartGame() {
		// min inclusive and max exclusive
		guess = UnityEngine.Random.Range(min, max+1);
		text.text = guess.ToString();
	}
	
	void NextGuess() {
		MaximumGuesses = MaximumGuesses - 1;
		if (MaximumGuesses <= 0) {
			Application.LoadLevel ("Win");
		} else {
			guess = UnityEngine.Random.Range(min, max+1);
			text.text = guess.ToString();
		}
	}

	public void GuessHigher() {
		min = guess + 1; // exclude the guess
		NextGuess();
	}

	public void GuessLower() {
		max = guess - 1; // exclude the guess
		NextGuess();
	}
}
