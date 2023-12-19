using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{


    [SerializeField] GameObject _player;
    [SerializeField] GameObject _respawnpoint;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("death"))
        {
            Debug.Log("AAAAAAAAAAAA");
            _player.GetComponent<CharacterController>().enabled = false;
            _player.transform.position = _respawnpoint.transform.position;
                        _player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
