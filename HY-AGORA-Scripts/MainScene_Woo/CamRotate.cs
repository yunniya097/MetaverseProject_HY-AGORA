using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //회전 속도 변수
    public float rotSpeed = 200f; //20f -> 200f 로 속도 높임

    float mx = 0;
    float my = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 입력을 받음
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        //회전 값 변수에 마우스 입력 값 누적
        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;
        
        // 마우스 상하 이동 회전 변수 값을 제한
        my = Mathf.Clamp(my, -90f, 90f); //(대상, 최소, 최대)

        transform.eulerAngles = new Vector3(-my, mx, 0);
        /*
        //회전 방향 결정
        Vector3 dir = new Vector3(-mouse_Y, mouse_X, 0);

        //물체를 회전
        transform.eulerAngles += dir * rotSpeed * Time.deltaTime;

        // y축의 값을 제한
        Vector3 rot = transform.eulerAngles;
        rot.x = Mathf.Clamp(rot.x, -90f, 90f);  //변수의 값을 상하한을정한다.
        transform.eulerAngles = rot;
        안 씀 
        */
        }
}
