using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class WeaponEnemy : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int anzahlMinus = 20;
    bool spam = false;
    public int spamSpeed = 8;
    
    void Shoot()
    {                
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); //Instantiate Bullet       
    }
    
    
    //Alles für den PipeSpam
    public void PipeSpam()
    {
        anzahlMinus = Score.blussi*spamSpeed;
        spam = true;        
    }
    void FixedUpdate()
    {
        if (spam == true) //PipeSpam Event
        {
            if (anzahlMinus % spamSpeed == 0)
            {
                Shoot();
                //Shoot();
            }
            anzahlMinus -= 1;
            if (anzahlMinus < 0) spam = false;
            Debug.Log("SPAM" + anzahlMinus);
        }
    }
}
