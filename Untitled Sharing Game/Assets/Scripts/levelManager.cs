using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
	private GameObject gameManager;
	private globalScore globalScore;

	void Start(){
		gameManager = GameObject.Find("GameManager");
		globalScore = gameManager.GetComponent<globalScore>();
	}

	public void endGame(){
		globalScore.updateScore();
		loadScene("EndScreen");
	}

	public void loadScene(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void quitGame(){
    	Application.Quit();
    }
}
