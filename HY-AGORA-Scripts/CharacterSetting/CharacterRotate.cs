using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotate : MonoBehaviour
{
    private float rotSpeed = 0.01f;

    private float r = 45;

    public int i = 0;
    Quaternion rot0 = Quaternion.Euler(new Vector3(0, 180, 0));
    
    /*오른쪽 버튼*/
    public void SetRotate_R()
    {
        rot0 = rot0 * Quaternion.Euler(new Vector3(0, r, 0));
    }
    /*왼쪽 버튼*/
    public void SetRotate_L()
    {
        rot0 = rot0 * Quaternion.Euler(new Vector3(0, -r, 0));
    }

    void Update()
    {      
        transform.rotation = Quaternion.Slerp(this.transform.rotation, rot0, rotSpeed);
    }
    
    
    
}
