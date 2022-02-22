using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerTxt;
    public float time = 60f;
    private float selectCountdown;
    bool TimerOn; // timer가 돌아가고 있는지
    GameObjClick objt;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = false;
        selectCountdown = time;
        objt = GetComponent<GameObjClick>();
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerOn) 
        {
            selectCountdown -= Time.deltaTime;
            timerTxt.text = Mathf.Floor(selectCountdown).ToString();
            if(selectCountdown == 0)
            {
                SetTimerStop();
                objt.SetGameOff();
            }
        }
    }

    public void SetTimerOn()
    {
        TimerOn = true;
    }

    public void SetTimerStop()
    {
        TimerOn = false;
    }

}
