using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject startbutton;
    public GameObject scoreboard;
    public GameObject timer;

    TimerCtrlBtn tmc;
    Timer tm;
    ScoreManager sm;

    private bool triggered = false;
    
    void Start()
    {
        tmc = startbutton.GetComponent<TimerCtrlBtn>();
        tm = timer.GetComponent<Timer>();
        sm = scoreboard.GetComponent<ScoreManager>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        //do something
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Debug.Log("HIT");
            tmc.ButtonView();
            tm.TimerView();
            sm.scorePanel0On();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        //do something after untouched
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = false;
            /*startbutton.SetActive(triggered);
            scoreboard.SetActive(triggered);
            timer.SetActive(triggered);*/

        }
    }
   
}
