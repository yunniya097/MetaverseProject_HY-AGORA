using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventInput : MonoBehaviour
{
    public GameObject EvenetInputView;

    public InputField intpuField_num;
    public Button EnterButton;
    public bool EnterButtonActive;

    ShowEvent evt;

    // Start is called before the first frame update
    void Start()
    {
        EnterButtonActive = false;
        evt = EvenetInputView.GetComponent<ShowEvent>();
    }

    public void EnterButtonClick()
    {
        if(!EnterButtonActive)
        {
            EnterButtonActive = true;
        }
        else
        {
            EnterButtonActive = false;
            evt.EventNotView();
        }
        
    }

}
