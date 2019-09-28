using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalScore : MonoBehaviour
{
	// https://www.sitepoint.com/saving-data-between-scenes-in-unity/
	public static globalScore Instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null){
        	DontDestroyOnLoad(gameObject);
        	Instance = this;
        }
        else if(Instance != this){
        	Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
