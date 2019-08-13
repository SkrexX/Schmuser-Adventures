using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowBox : MonoBehaviour
{
    public Vector3 growVector = new Vector3(0.2f, 0.2f, 0);
    public float maxGrowth = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D colliderObject)
    {
        if (transform.localScale.x <= maxGrowth & transform.localScale.y <= maxGrowth & colliderObject.tag == "BlussiBullet") 
        {
            gameObject.transform.localScale += growVector;
        }

    }
}
