using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AjoutPoints : MonoBehaviour
{
    private int points;

    [SerializeField] Text _scoretext;

    [SerializeField] private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _scoretext.text = points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        points = _gameManager._score;
        _scoretext.text = points.ToString();
    }

    public void CompleteLevel()
    {
        _gameManager._score += 10;
        points = _gameManager._score;
        _scoretext.text = points.ToString();
    }
}
