using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    public Vector2 lastCheckPointPos;
    public int scoreSave;
    bool dead = false; //Status
    public GameObject ripText;
    public GameObject player;//Prefab first, then Object

    void Awake()//Always have exactly one instance of the Onject alive
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //ripText = GameObject.FindGameObjectWithTag("GameOverText");
    }
    void Update()
    {
        //if (Score.blussi < -15) Death();
        if (Input.GetButtonDown("Reload"))
        {
            Restart();
        }
        //Debug.Log(lastCheckPointPos);
        //player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Restart()
    {
        dead = false;
        ripText.SetActive(false);
        LoadCheckPoint();
    }
    public void Death()
    {
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.Die();
        ripText.SetActive(true);
        dead = true;
    }
    void LoadCheckPoint()//SaveCheckpoint in Script "Checkpoint"
    {        
        player.transform.position = lastCheckPointPos;
        player.SetActive(true);
        
    }
}
