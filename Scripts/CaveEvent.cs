using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveEvent : MonoBehaviour
{
    public GameObject mieserBoss;
    public GameObject pipe;
    WeaponEnemy pipeWeaponScript;
    bool isTriggered = false;

    public AudioClip soundClip;
    public AudioSource soundSource;
    public PlayerMovement playerMovement;
    public GameObject backgroundMusic;
    public GameObject intenseMusic;

    int counter = 0;
    bool eventbool = false;


    //MieserSound
    //Delay
    //FadeOut, Blussi Weg, Ausgang freilegen


    void Start()
    {
        soundSource.clip = soundClip;//Bind Clip to soundSource     
        soundSource = this.GetComponent<AudioSource>();        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (isTriggered) return; //force single Use
        isTriggered = true;

        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        Vector3 pos = new Vector3(45.5f, -21.9f, 0f);
        Vector3 rot = new Vector3(0f, 0f, 0f);
        Debug.Log("CaveEvent Triggered");
        Instantiate(mieserBoss, pos, Quaternion.Euler(0, 0, 0)); //Spawn MieserBoss

        /*while (Score.blussi > 5) //Blussis abziehen
        {//Delay einfügen
            Score.blussi -= 1;
        }*/

        //Minusregen
        Minusregen();

        //VoiceLine Mieser
        backgroundMusic.SetActive(false);
        soundSource.Play();//Play Sound



    }
    //Spawn a Pipe and make it rain Minus
    void Minusregen()
    {
        Vector3 pos = new Vector3(36.5f, -22f, 0f);
        Instantiate(pipe, pos, Quaternion.Euler(0, 0, 90));//Pipe erzeugen und binden
        pipe = GameObject.Find("Pipe(Clone)");
        pipeWeaponScript = (WeaponEnemy)pipe.GetComponent(typeof(WeaponEnemy));
        //pipeWeaponScript.PipeSpam();//Spam auslösen
        Score.blussiSave = Score.blussi;//Blussi Count für Später speichern

        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerMovement.move = false; //Spieler temporär unbeweglich machen
        eventbool = true; //Fixed Update aktivieren
        playerMovement.controller.Move(0.1f * Time.fixedDeltaTime, false, false); //Nach rechts drehen
        playerMovement.horizontalMove = 0;
    }

    void FixedUpdate()
    {
        if (eventbool == true)
        {
            counter += 1;

            if (counter == 300)//Spam verzögert auslösen
            {
                pipeWeaponScript.PipeSpam();
            }
            if (counter >= 480 & Score.blussi < 0)//wieder beweglich machen
            {
                playerMovement.move = true;                              
            }
            if (counter >= 650 & Score.blussi < 0)//Musik starten
            {
                intenseMusic.SetActive(true);
                eventbool = false;
                counter = 0;               
            }
        }
    }
}
