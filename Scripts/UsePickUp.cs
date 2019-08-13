using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePickUp : MonoBehaviour
{
    public GameObject weapon;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //weapon = GameObject.FindGameObjectWithTag("Weapon");

            //Waffenmodus umstellen
            Weapon weaponScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Weapon>();
            weaponScript.waffe = 1;

            //Waffe sichtbar aufsammeln
            weapon.SetActive(true);
            Destroy(gameObject);
            Debug.Log("UsePickUpTrigger");
            
        }
        
    }
}
