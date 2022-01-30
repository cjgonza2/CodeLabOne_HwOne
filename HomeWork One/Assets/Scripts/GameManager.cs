using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int punchScore;
    
    public float timer;

    public Text scoreText;
    public Text timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 15;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Score: " + punchScore + " punches");
        timerText.text = "Time Remaining: " + timer;

        if(timer  > 0)
        {
            timer -= Time.deltaTime;
        }
        Mathf.Round(timer * 100f / 100f);

        if(timer <= 0)
        {

        }
    }
}
