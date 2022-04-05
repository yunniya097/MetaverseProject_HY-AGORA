using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    public float rotSpeed = 0.05f;

    /*회전 각도*/
    private float r = 90;
    Quaternion rot0;

    private void Start()
    {
        rot0 = transform.rotation;
    }

    //pressButton();
    private void Update()
    {
        /*E키를 누르면 시계방향으로 회전*/
        if (Input.GetKeyDown(KeyCode.E))
        {
            /*회전 목적지 설정*/
            rot0 = rot0 * Quaternion.Euler(new Vector3(0, r, 0));
        }

        /*Q키를 누르면 반시계방향으로 회전*/
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rot0 = rot0 * Quaternion.Euler(new Vector3(0, -r, 0));
        }

        transform.rotation = Quaternion.Slerp(this.transform.rotation, rot0, rotSpeed);
        
        
        /*transform.rotation = Quaternion.Slerp(this.transform.rotation, rot0, rotSpeed);*/
    }
    
}
