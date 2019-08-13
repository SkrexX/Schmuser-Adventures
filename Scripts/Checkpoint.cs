using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    public GameObject player;
    public Text checkpointText;
    int counter = 0;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        player = GameObject.FindGameObjectWithTag("Player");
        checkpointText = GameObject.FindGameObjectWithTag("CheckpointText").GetComponent<Text>();
        checkpointText.enabled = false;
    }

    //SaveCheckpoint
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BlussiBullet"))
        {
            gm.lastCheckPointPos = player.transform.position;
            //gm.scoreSave = Score.blussi;
            Debug.Log("Checkpoint saved");            
            checkpointText.enabled = true;

        }

    }

    void FixedUpdate()
    {

        if (checkpointText.enabled == true)
        {

            counter += 1;
            if (counter >= 100)
            {
                checkpointText.enabled = false;
                counter = 0;
            }
        }

        Debug.Log(counter);
    }
}
