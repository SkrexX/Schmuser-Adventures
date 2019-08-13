using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootKI : MonoBehaviour
{
    public GameObject bulletMinus;
    public Transform firePoint;
    public WeaponEnemy weaponScript;
    int a = 0;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (a%80==0)
            Instantiate(bulletMinus, firePoint.transform.position, firePoint.rotation);
        a += 1;
    }
}