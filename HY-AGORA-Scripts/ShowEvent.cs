using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEvent : MonoBehaviour
{
    public GameObject EventPanel;
    public bool EventButtonActive;
    public GameObject Result;

    ScoreManager sm;

    // Start is called before the first frame update
    void Start()
    {
        sm = Result.GetComponent<ScoreManager>();
        EventPanel.SetActive(false);
        EventButtonActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickEventButton()
    {
        if(!EventButtonActive)
        {
            EventButtonActive = true;
            EventView();
            //sm.WinPanelOff();
            Result.SetActive(false);    
        }
        else
        {
            EventButtonActive = false;
            EventNotView();
        }
    }

    public void EventView()
    {
        EventPanel.SetActive(true);
    }

    public void EventNotView()
    {
        EventPanel.SetActive(false);
    }
}
