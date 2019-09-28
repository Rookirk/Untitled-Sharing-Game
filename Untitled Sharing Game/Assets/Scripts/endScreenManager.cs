using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScreenManager : MonoBehaviour
{
	private GameObject gameManager;
    private globalScore globalScore;
    private GameObject textDisplay;
    private Text scoreDisplay;

	void Start(){
		gameManager = GameObject.Find("GameManager");
		globalScore = gameManager.GetComponent<globalScore>();

		textDisplay = GameObject.Find("Score");
		scoreDisplay = textDisplay.GetComponent<Text>();

		scoreDisplay.text = globalScore.timeScore.ToString();
	}
}
