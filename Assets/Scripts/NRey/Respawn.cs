using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _respawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

 void OnCollisionEnter(Collision other)
{
            if(other.gameObject.tag == "death"){
                Debug.Log($"AAAAAAAAAAAA");
        _player.transform.position = _respawnpoint.transform.position;
        }
}
}
