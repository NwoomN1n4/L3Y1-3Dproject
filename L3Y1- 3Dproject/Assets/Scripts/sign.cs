using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sign : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = true;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
       {
        canvas.enabled = true;
       } 
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canvas.enabled = false;
        }
    }
}

