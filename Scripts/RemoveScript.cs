using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveScript : MonoBehaviour
{
    // This script is made to destroy an animation after 1 second
    void Start()
    {
        StartCoroutine(Destruction());        
    }

    IEnumerator Destruction()
    {       
        yield return new WaitForSeconds (1);
        Destroy(gameObject);
    }
}
