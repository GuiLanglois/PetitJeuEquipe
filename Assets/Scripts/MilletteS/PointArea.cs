using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointArea : MonoBehaviour
{

    public static PointArea instance;
    
    public Text scoreText;
    public GameObject portail;

    int score = 0;

     /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    void Update()
    {
        
    }
    

    public void AddPoint(){
        score += 1;
        scoreText.text = score.ToString();

        if(score >= 4){
            portail.SetActive(true);

        }
    }
}
