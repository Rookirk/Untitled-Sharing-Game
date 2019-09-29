using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyPresser : MonoBehaviour
{
	// public Sprite spriteA;
	// public Sprite spriteB;

 //    // // Start is called before the first frame update
 //    // void Start()
 //    // {
        
 //    // }

 //    // Update is called once per frame
 //    void Update ()
	// {
	// 	if(Input.GetKeyDown (KeyCode.W))
	// 	{
	// 		GetComponent<SpriteRenderer>().sprite = spriteA;
	// 	}
	// 	if(Input.GetKeyUp (KeyCode.W))
	// 	{
	// 		GetComponent<SpriteRenderer>().sprite = spriteB;
	// 	}
	// }
	//Image myImageComponent; // Image component attached to this gameobject
	SpriteRenderer myImageComponent;
 
	public Sprite originalSprite;
	public Sprite pressedSprite;
	public KeyCode myKey = KeyCode.W;
	public KeyCode otherKey = KeyCode.W;
	void Start() //Lets start by getting a reference to our image component.
	{
		//myImageComponent = GetComponent<Image>();
		myImageComponent = GetComponent<SpriteRenderer>();
		Debug.Log(myImageComponent == null);
	}
 
	void Update()
	{
		if(Input.GetKey(myKey) || Input.GetKey(otherKey))
		{
			myImageComponent.sprite  = pressedSprite;
			Debug.Log("PRESSED");
			Debug.Log(myImageComponent.sprite);
		}
		else if(Input.GetKeyUp(myKey) || Input.GetKeyUp(otherKey))
		{
			myImageComponent.sprite = originalSprite;
			Debug.Log("RELEASED");
		}
	}
}




