using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    bool isColliding;
    //On Touch with the Player, the Item executes its use
    public void OnTriggerEnter2D (Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.gameObject.name);
        

        if (hitInfo.gameObject.tag == "Player" & gameObject.tag=="BlussiDrop")
        {            
            if (isColliding) return; //If the boolean is true, quit the method, else set it to true and do the rest.
            isColliding = true;

            Debug.Log("Execute Pick Up");            
            Destroy(gameObject);
            Score.IncreaseScore(5);

            
        }
        
    }

}
