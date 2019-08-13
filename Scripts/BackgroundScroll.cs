using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speedx = 0.01f;
    public float speedy = 0.005f;
    public GameObject playervar;
    void Start()
    {
        playervar = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() 
    {
        Vector2 offset = new Vector2(playervar.transform.position.x * speedx, playervar.transform.position.y * speedy);
        
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
