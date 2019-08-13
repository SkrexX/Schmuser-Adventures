using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    bool cooldown = false;
    public int waffe = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Key Input Shot
        if (Input.GetButton("Fire1") & cooldown == false)
        {
            cooldown = true;
            Shoot();
            if (waffe == 0)
            {
                StartCoroutine(Wait(1.5f));
            }
            if (waffe == 1)
            {
                StartCoroutine(Wait(0.2f));
            }

        }


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
