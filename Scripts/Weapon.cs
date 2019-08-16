using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    bool cooldown = false;
    public int weapon = 0;
    public bool[] weaponEnable = new bool[3];
    //public GameObject weaponAR;
    //public GameObject weaponGL;
    public GameObject[] weaponObject = new GameObject[3];

    // Update is called once per frame

    void Start()
    {
        weaponEnable[0] = true; //Waffe 0 immer erlaubt
    }

    void Update()
    {//WeaponSwitch
        if (Input.GetKeyDown("0"))
        {
            if (weaponEnable[0] == true)
            {
                SwitchWeapon(0);
            }
        }
        if (Input.GetKeyDown("1"))
        {
            if (weaponEnable[1] == true)
            {
                SwitchWeapon(1);
            }
        }
        if (Input.GetKeyDown("2"))
        {
            if (weaponEnable[2] == true)
            {
                SwitchWeapon(2);
            }
        }
    }

    void FixedUpdate()
    {
        //Key Input Shot
        if (Input.GetButton("Fire1") & cooldown == false)
        {
            cooldown = true;
            Shoot();
            if (weapon == 0)
            {
                StartCoroutine(Wait(1.5f));
            }
            if (weapon == 1)
            {
                StartCoroutine(Wait(0.2f));
            }
            if (weapon == 2)
            {
                StartCoroutine(Wait(1.5f));
            }

        }


    }

    void SwitchWeapon(int weapon_)
    {
        foreach (GameObject i in weaponObject) //make all weapons invisible
        {
            i.SetActive(false);
        }
        weapon = weapon_;
        weaponObject[weapon_].SetActive(true);//Switch Weapon and make visible
    }

    void Shoot()
    {
        //Shooting Logic Player
        if (gameObject.tag == "Player")
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }

    IEnumerator Wait(float zeit)
    {
        yield return new WaitForSeconds(zeit);
        cooldown = false;
    }
}
