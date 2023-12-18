using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreFin : MonoBehaviour
{

    private int _points;
    [SerializeField] TMP_Text _scoretext;

    [SerializeField] private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _scoretext.text = _points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _points = _gameManager._score;
    }
}
