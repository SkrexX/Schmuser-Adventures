using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RIP : MonoBehaviour
{
    GameMaster gm;

    void Start()
    {
        gm= GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    

    void OnTriggerEnter2D(Collider2D colliderObject)
    {
        if (colliderObject.tag == "Player")
        {
            gm.Death();
        }

    }
}
