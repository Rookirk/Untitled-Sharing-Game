using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
	public void loadScene(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void quitGame(){
    	Application.Quit();
    }
}
