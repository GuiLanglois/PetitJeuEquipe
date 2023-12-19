using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDisparait : MonoBehaviour
{

    public GameObject text;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AfficherTexte());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AfficherTexte()
    {
        yield return new WaitForSeconds(10);
        text.SetActive(false);
    }
}
