using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherPellet : MonoBehaviour
{
    public float speed = 10f;
    public float speedshard = 20f;
    public int damage = 10;
    public Rigidbody2D rb;
    public GameObject bulletPrefab;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    //PlayerPellet hitting
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "BlussiBullet")
        {

        }
        else
        {
            Vector3 temp = transform.rotation.eulerAngles;
            Destroy(gameObject);
            for (float i = 0f; i <= 359f; i += 45f)
            {
                temp.z = i;
                this.transform.rotation = Quaternion.Euler(temp);
                Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
            }
        }

    }
}
