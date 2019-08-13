using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
    public ItemDrop itemdropper;     //ItemDrop Script
    //public ItemPickUp itemPickUp;
    
    
    
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
        }
        Destroy(gameObject);
        itemdropper.OnDeath();          //Trigger ItemDrop
    }
    
    

    
}
