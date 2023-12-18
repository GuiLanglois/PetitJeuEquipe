using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeLeft;
    public Text timertext;

    private LevelManager _levelManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(timeLeft >= 0)
        {
            timeLeft -= Time.deltaTime;
            updateTimer(timeLeft);
        }

        if(timeLeft <= 0)
        {
            FinJeu();
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timertext.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    
    void FinJeu()
    {
        _levelManager.LoadAsyncScene(LevelManager.Scene.SceneFin);
        
        
    }
}
