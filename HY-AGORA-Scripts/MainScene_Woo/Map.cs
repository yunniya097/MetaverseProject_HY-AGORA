using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{    
    /*Q눌러서 돌리는 패널*/
    public GameObject Object1;
    /*Event 돌리는 패널*/
    public GameObject Object2;
    /*돌리는 대상*/
    public GameObject Object3;


    /*돌리는 속도*/
    public float rotSpeed = 0.015f;

    /*회전 각도*/
    private float r = 90;
    /*기본 로테이션 초기화*/
    Quaternion rot0;

    /*플레이어가 닿아 있냐*/
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
                /*회전 목적지 설정*/
                rot0 = rot0 * Quaternion.Euler(new Vector3(0, r, 0));
            }


            /*Q키를 누르면 반시계방향으로 회전*/
            if (Input.GetKeyDown(KeyCode.Q))
            {
                rot0 = rot0 * Quaternion.Euler(new Vector3(0, -r, 0));
            }
        }    

        Object3.transform.rotation = Quaternion.Slerp(Object3.transform.rotation, rot0, rotSpeed);      
    }
}
