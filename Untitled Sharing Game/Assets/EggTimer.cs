using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggTimer : MonoBehaviour
{
    //get the level manager to end the game
    //GameObject gameManager = GameObject.Find("GameManager");

    //initialize the heat countdown
    private float heat = 1000.0f;
    private bool sit = false;

    private void Start()
    {
        Debug.Log("Game start with Eggs");
        //Debug.Log("component type of the script is " + gameManager.GetComponent<levelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //heat countdown if not triggered
        if (sit == false && heat > 0)
        {
            heat -= Time.deltaTime;
        } else if (sit == true && heat > 0)
        {
            heat += (Time.deltaTime * 3);
        }
        else if (heat <= 0)
        {
            //levelManager.endGame();
            Debug.Log("An Egg is dead! GAME OVER!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered Egg, heat is now " + heat);
        sit = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("exitied Egg trigger, heat is now " + heat);
        sit = false;
    }
}
