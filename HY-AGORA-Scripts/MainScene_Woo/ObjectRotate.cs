using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    public float rotSpeed = 0.05f;

    /*ȸ�� ����*/
    private float r = 90;
    Quaternion rot0;

    private void Start()
    {
        rot0 = transform.rotation;
    }

    //pressButton();
    private void Update()
    {
        /*EŰ�� ������ �ð�������� ȸ��*/
        if (Input.GetKeyDown(KeyCode.E))
        {
            /*ȸ�� ������ ����*/
            rot0 = rot0 * Quaternion.Euler(new Vector3(0, r, 0));
        }

        /*QŰ�� ������ �ݽð�������� ȸ��*/
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rot0 = rot0 * Quaternion.Euler(new Vector3(0, -r, 0));
        }

        transform.rotation = Quaternion.Slerp(this.transform.rotation, rot0, rotSpeed);
        
        
        /*transform.rotation = Quaternion.Slerp(this.transform.rotation, rot0, rotSpeed);*/
    }
    
}
