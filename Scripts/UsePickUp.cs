using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePickUp : MonoBehaviour
{
    public GameObject weaponAR;
    public GameObject weaponGL;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //weapon = GameObject.FindGameObjectWithTag("Weapon");
            if (gameObject.CompareTag("WeaponAR"))
            {
                //Waffenmodus umstellen
                Weapon weaponScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Weapon>();
                weaponScript.weaponEnable[1] = true;
                weaponScript.weapon = 1;

                //Waffe sichtbar aufsammeln
                weaponAR.SetActive(true);
                Destroy(gameObject);
                Debug.Log("UsePickUpTrigger");
            }
            if (gameObject.CompareTag("WeaponGL"))
            {
                //Waffenmodus umstellen
                Weapon weaponScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Weapon>();
                weaponScript.weaponEnable[2] = true;
                weaponScript.weapon = 2;

                //Waffe sichtbar aufsammeln
                weaponGL.SetActive(true);
                Destroy(gameObject);
                Debug.Log("UsePickUpTrigger");
            }

        }

    }
}
