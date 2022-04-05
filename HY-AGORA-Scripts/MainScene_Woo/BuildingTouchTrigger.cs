using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTouchTrigger : MonoBehaviour
{
    /*F������ Ȯ�� �ȳ� �г�*/
    public GameObject Object0;

    /*��ü ������ �Ѱ� ����*/
    public GameObject Object1;

    /*Ȯ���� ����*/
    public GameObject Object2;

    /*X��ư �г�*/
    public GameObject Object3;

    Renderer[] renderers;

    /*�÷��̾ ��� �ֳ�*/
    private bool triggered = false;

    private bool boolean = true;

    private void Start()
    {
        renderers = Object1.GetComponentsInChildren<Renderer>();
    }
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
        triggered = false;
        //do something after untouched
        Object0.SetActive(triggered);
    }


    void Update()
    {

        if (triggered)
        {
            //do something per frame
            if (Input.GetKeyDown(KeyCode.F))
            {
                boolean = !boolean;
                foreach (var r in renderers)
                {
                    r.enabled = boolean;
                }
                Object2.SetActive(!boolean);
                Object3.SetActive(!boolean);
                boolean = !boolean;

            }

        }

        /*X������ Ȯ��� ������ ���ֱ�*/
        if (Input.GetKeyDown(KeyCode.X))
        {
            Object2.SetActive(false);
            Object3.SetActive(false);
            foreach (var r in renderers)
            {
                r.enabled = true;
            }
        }


    }
}
