using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{

	public float time = 0.0f;

	private globalScore globalScore;

	void Start(){
		globalScore = GetComponent<globalScore>();
	}

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    public void updateScore(){
    	globalScore.timeScore = time;
    }
}
