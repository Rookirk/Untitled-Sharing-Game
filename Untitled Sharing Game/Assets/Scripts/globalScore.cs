using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalScore : MonoBehaviour
{
	// https://www.sitepoint.com/saving-data-between-scenes-in-unity/
	public static globalScore instance;

	public float timeScore;

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
}
