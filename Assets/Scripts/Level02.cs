using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02 : MonoBehaviour
{
     private LevelManager _levelManager;
    // Start is called before the first frame update
    void Start()
    {
       _levelManager = LevelManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        _levelManager.LoadAsyncScene(LevelManager.Scene.LangloisGuillaumeInterieur);
    }
}
