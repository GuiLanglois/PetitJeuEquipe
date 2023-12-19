using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoutPoint1 : MonoBehaviour
{
   public GameObject Potion;

   
   private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("potion"))
            {
                PointArea.instance.AddPoint();
                Destroy(other.gameObject);
            }
    }
   
   
    
    
   
}
