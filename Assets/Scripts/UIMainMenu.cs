using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    
    [SerializeField] Button _newgame;

        [SerializeField] Button _quit;

        private LevelManager _levelManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;
        _newgame.onClick.AddListener(StartNewGame);
    }
    
    private void StartNewGame()
    {
        _levelManager.NewGame();
    }
        private void QuitGame()
    {
        _levelManager.QuitGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
