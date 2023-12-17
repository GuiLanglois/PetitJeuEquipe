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
    }

    public void CompleteLevel()
    {
        points += 10;
        _scoretext.text = points.ToString();
    }
}
