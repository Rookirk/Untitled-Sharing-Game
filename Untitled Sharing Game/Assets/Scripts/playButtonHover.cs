using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playButtonHover : MonoBehaviour
{
	public Sprite unHover;
	public Sprite yesHover;
	private Image imageComp;

	void Start(){
		imageComp = GetComponent<Image>();
	}

    public void changeOnHover(){
    	imageComp.sprite = yesHover;
    }

    public void notHovering(){
    	imageComp.sprite = unHover;
    }
}
