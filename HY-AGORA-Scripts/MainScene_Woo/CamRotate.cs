using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //ȸ�� �ӵ� ����
    public float rotSpeed = 200f; //20f -> 200f �� �ӵ� ����

    float mx = 0;
    float my = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���콺 �Է��� ����
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        //ȸ�� �� ������ ���콺 �Է� �� ����
        mx += mouse_X * rotSpeed * Time.deltaTime;
        my += mouse_Y * rotSpeed * Time.deltaTime;
        
        // ���콺 ���� �̵� ȸ�� ���� ���� ����
        my = Mathf.Clamp(my, -90f, 90f); //(���, �ּ�, �ִ�)

        transform.eulerAngles = new Vector3(-my, mx, 0);
        /*
        //ȸ�� ���� ����
        Vector3 dir = new Vector3(-mouse_Y, mouse_X, 0);

        //��ü�� ȸ��
        transform.eulerAngles += dir * rotSpeed * Time.deltaTime;

        // y���� ���� ����
        Vector3 rot = transform.eulerAngles;
        rot.x = Mathf.Clamp(rot.x, -90f, 90f);  //������ ���� �����������Ѵ�.
        transform.eulerAngles = rot;
        �� �� 
        */
        }
}
