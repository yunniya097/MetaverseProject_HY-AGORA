using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{    
    /*Q������ ������ �г�*/
    public GameObject Object1;
    /*Event ������ �г�*/
    public GameObject Object2;
    /*������ ���*/
    public GameObject Object3;


    /*������ �ӵ�*/
    public float rotSpeed = 0.015f;

    /*ȸ�� ����*/
    private float r = 90;
    /*�⺻ �����̼� �ʱ�ȭ*/
    Quaternion rot0;

    /*�÷��̾ ��� �ֳ�*/
    private bool triggered = false;


    private void Start()
    {
        rot0 = Object3.transform.rotation;
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        //do something
        if (other.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Debug.Log("HIT");
            Object1.SetActive(triggered);
            Object2.SetActive(triggered);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        triggered = false;
        //do something after untouched
        Object1.SetActive(triggered);
        Object2.SetActive(triggered);/*
        if (other.gameObject.CompareTag("Player"))
        {
            
           
        }*/
    }


    void Update()
    {
        
        if (triggered)
        {
            //do something per frame
            if (Input.GetKeyDown(KeyCode.F))
            {
                Object1.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("e");
                /*ȸ�� ������ ����*/
                rot0 = rot0 * Quaternion.Euler(new Vector3(0, r, 0));
            }


            /*QŰ�� ������ �ݽð�������� ȸ��*/
            if (Input.GetKeyDown(KeyCode.Q))
            {
                rot0 = rot0 * Quaternion.Euler(new Vector3(0, -r, 0));
            }
        }    

        Object3.transform.rotation = Quaternion.Slerp(Object3.transform.rotation, rot0, rotSpeed);      
    }
}
