using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
	public void loadScene(string level)
    {
        Application.LoadLevel(level);
    }

    public void quitGame(){
    	Application.Quit();
    }
}
