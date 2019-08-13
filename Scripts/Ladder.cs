using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    private bool onLadder = false;


    void Update()
    {
        rb.gravityScale = 3;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //rb.gravityScale = 0;
            onLadder = true;
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //rb.gravityScale = 3;
            onLadder = false;
        }

    }
    void FixedUpdate()
    {
        if (onLadder == true)
        {
            if (Input.GetAxisRaw("Vertical") > 0)
            {
                player.transform.position = player.transform.position + new Vector3(0, Input.GetAxisRaw("Vertical") * Time.fixedDeltaTime, 0);
            }
        }
    }
}
