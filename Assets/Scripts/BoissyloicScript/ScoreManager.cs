using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
   public static ScoreManager instance;

    public Text scoreText;
    public GameObject portail;

    int score;

    [SerializeField] private GameManager _gameManager;

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

    // Update is called once per frame
    void Update()
    {
        score = _gameManager._score;
        scoreText.text = score.ToString();
    }

    public void AddPoint(){
        _gameManager._score += 1;
        score = _gameManager._score;
        scoreText.text = score.ToString();

        if(_gameManager._score >= 5){
            portail.SetActive(true);

        }

        if(_gameManager._score >= 50)
        {
             SceneManager.LoadScene("SceneFin");

        }
    }
}
