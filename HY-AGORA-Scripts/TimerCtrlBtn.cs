using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCtrlBtn : MonoBehaviour
{
    public bool ButtonActive; // 지금 숫자 세고 있는지
    public GameObject TimerManager;
    Timer tm;
    GameObjClick objt;
    ScoreManager sm;
    
    void Start()
    {
        ButtonActive = false;
        tm = TimerManager.GetComponent<Timer>();
        objt = GetComponent<GameObjClick>();
        sm = GetComponent<ScoreManager>();
        
    }

    void Update()
    {
        
    }

    public void ClickButton()
    {
        if(!ButtonActive)
        {
            // 시작해야 되는 부분
            tm.SetTimerOn();
            objt.SetGameOn();
            ButtonActive = true;
        }
        else
        {
            // stop
            tm.SetTimerStop();
            objt.SetGameOff();
            ButtonActive = false;
            sm.GameOver();
            
        }
    }

    
}
