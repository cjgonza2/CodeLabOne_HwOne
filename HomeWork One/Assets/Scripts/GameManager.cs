using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int punchScore;
    
    public float timer;
    public float f;

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
        timerText.text = "Time Remaining: " + f;

        if(timer  > 0)
        {
            timer -= Time.deltaTime;
        }
        
        f = Mathf.Round((timer * 10.0f) * 0.1f);

        if(timer <= 0)
        {

        }
    }
}