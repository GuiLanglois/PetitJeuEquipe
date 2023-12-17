using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointSphere : MonoBehaviour
{
    public GameObject sphere;
   
   private void OnTriggerEnter(Collider other)
   {
      ScoreManager.instance.AddPoint();
      Destroy(sphere);

   
      
   }
}
