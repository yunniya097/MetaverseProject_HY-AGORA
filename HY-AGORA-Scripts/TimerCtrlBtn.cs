using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCtrlBtn : MonoBehaviour
{
    public bool ButtonActive; // 지금 숫자 세고 있는지
    public GameObject TimerManager;
    public GameObject GameManager;
    public GameObject GameStartButton;

    Timer tm;
    GameObjClick objt;
    
    void Start()
    {
        ButtonActive = false;
        tm = TimerManager.GetComponent<Timer>();
        objt = GameManager.GetComponent<GameObjClick>();
        GameStartButton.SetActive(false);
    }

    public void ClickButton()
    {
        if(!ButtonActive)
        {
            /*수정된거*/
            GameStartButton.SetActive(false);
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
        }
    }

    public void ButtonView()
    {
        GameStartButton.SetActive(true);
    }

    public void ButtonUnView()
    {
        GameStartButton.SetActive(false);
    }

    
}
