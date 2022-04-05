using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyOpenDoor : MonoBehaviour
{
    /*F ������� �ȳ� �г�*/
    public GameObject Object0;


    private bool triggered = false;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        //do something
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Debug.Log("HIT");
            Object0.SetActive(triggered);


        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        //do something after untouched
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = false;
            Object0.SetActive(triggered);

        }
    }
    void Update()
    {
        if (triggered)
        {
            //do something per frame
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene("MainScene");
            }
        }
    }
}
