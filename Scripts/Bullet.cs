using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    //PlayerBullet hitting Enemy
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        else if (hitInfo.tag == "BlussiBullet")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }
    //EnemyBullet hitting Player
    void OnCollisionEnter2D (Collision2D hitInfo)
    {
        if (hitInfo.gameObject.name == "Player")
        {
            Debug.Log("Player hit");
            Destroy(gameObject);
            Score.IncreaseScore(-1);
        }
        else if (gameObject.tag == "MinusGround")
        {

        }
        else
        {
            Destroy(gameObject);
        }
    }


}
