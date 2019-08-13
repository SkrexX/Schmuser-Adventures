using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Blussi-Counter
    public static int blussi;
    public static int blussiSave;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Blussi: " + blussi;
    }
        
    
    public static void IncreaseScore(int amount)
        {
            Score.blussi += amount;
        }
}
