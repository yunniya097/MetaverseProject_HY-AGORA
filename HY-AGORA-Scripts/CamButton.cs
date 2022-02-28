using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamButton : MonoBehaviour
{
    public GameObject cambtnpanel1;
    public GameObject cambtnpanel2;

    
    private bool triggered = false;
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        //do something
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Debug.Log("HIT");
            cambtnpanel1.SetActive(triggered);
            cambtnpanel2.SetActive(triggered);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        //do something after untouched
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = false;
            cambtnpanel1.SetActive(triggered);
            cambtnpanel2.SetActive(triggered);

        }
    }
   
}
