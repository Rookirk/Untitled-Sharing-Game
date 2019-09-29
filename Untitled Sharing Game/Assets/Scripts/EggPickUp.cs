using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggPickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //called when this Egg collides with a Player
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collided with test Egg");
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Egg was hit by Player, otherCollider = " + col.otherCollider + "incoming = " + col.gameObject);

            //instantly move egg to attach to bottom left corner of Player
            col.otherCollider.gameObject.transform.parent = col.gameObject.transform;
            Debug.Log("Egg's coords are " + col.otherCollider.gameObject.transform.localPosition + "relative to " + col.gameObject);
            col.otherCollider.gameObject.transform.localPosition = new Vector3(1, 1, 1);
            Debug.Log("Egg's coords are " + col.otherCollider.gameObject.transform.localPosition + "relative to " + col.gameObject);
        }

    }
}
