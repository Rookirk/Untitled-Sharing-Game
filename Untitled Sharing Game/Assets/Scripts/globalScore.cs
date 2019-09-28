using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalScore : MonoBehaviour
{
	// https://www.sitepoint.com/saving-data-between-scenes-in-unity/
	public static globalScore instance;

	public float timeScore;

	private timer timerComp;
	private levelManager levelManager;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null){
        	DontDestroyOnLoad(gameObject);
        	instance = this;
        }
        else if(instance != this){
        	Destroy(gameObject);
        }
    }

    void Start(){
    	timerComp = GetComponent<timer>();
    	levelManager = GetComponent<levelManager>();
    }

    public void loadEndScreen(){
    	updateScore();
    	levelManager.loadScene("EndScreen");
    }

    public void updateScore(){
    	timeScore = timerComp.getTime();
    }
}
