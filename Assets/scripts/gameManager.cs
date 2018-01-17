using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

    public float timer;
    public Text timerText;
    public Text scoreText;

    private int score;
    private float timerDisplay;
    private float timerReset;

    void Start() {
        score = 0;
        timerReset = timer;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update() {
        timer -= Time.deltaTime; // subtact time each frame

        if (timer <= 0)
        {
            // reset timer
            timer = timerReset;
        }
        else
        {
            timerDisplay = Mathf.Round(timer);
            timerText.text = timerDisplay.ToString();
        }
    }
}
