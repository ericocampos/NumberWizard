using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max, min, guess;
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update (){
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I WON!!");
			StartGame();
		}
	}

	void StartGame () {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);

		print ("===========================");
		print ("Bem-Vindo ao Number Wizard");
		print ("Escolha um número na sua cabeça e não me conte!");

		print ("Escolha um número entre " + min + " e " + max);
		print ("O número é maior ou menor que " + guess + "?");
		print ("Seta para cima = Maior, Seta para baixo = Menor e Enter = Igual");

		max = max + 1;
	}

	void NextGuess (){
		guess = (max + min)/2;
		print ("Maior ou menor que " + guess);
		print ("Seta para cima = Maior, Seta para baixo = Menor e Enter = Igual");
	}
}
