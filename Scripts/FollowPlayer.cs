using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowPlayer : MonoBehaviour
{
    private CinemachineVirtualCamera vcam;

    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        vcam.Follow = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        
    }


}
