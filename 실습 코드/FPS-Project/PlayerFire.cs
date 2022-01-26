using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfire : MonoBehaviour
{
    // 무기 발사 위치 지정
    public GameObject firePosition;
    // 무기 오브젝트
    public GameObject bombFactory;
    // 투척 파워
    public float throwPower = 15f;
    // Start is call'ed before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 버튼을 통해 무기 발사
        if(Input.GetMouseButtonDown(1)){
            GameObject bomb = Instantiate(bombFactory);
            bomb.transform.position = firePosition.transform.position;
            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            // 카메라의 정면으로 무기에 물리적 힘 가함
            rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
        }
    }
}
