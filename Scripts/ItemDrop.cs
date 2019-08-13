using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    //Script to make an Item >drop< drop.

    public GameObject drop;
    

    public void OnDeath()
    {
        Instantiate(drop, transform.position, transform.rotation);
        Debug.Log("Ondeath triggered");
    }

}
