using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 7f;
    CharacterController cc;
    // 중력 변수
    float gravity = -20f;
    // 수직 속력 변수
    float yVelocity = 0;
    // 점프력 변수
    public float jumpPower = 10f;
    // 점프 상태 변수
    public bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical"); 

        // 이동 방향 설정
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        // 메인 카메라를 기준으로 방향 변경
        dir = Camera.main.transform.TransformDirection(dir);

        transform.position += dir * moveSpeed * Time.deltaTime;

        // 점프 중이고, 바닥에 착지했을 때
        if(isJumping && cc.collisionFlags == CollisionFlags.Below){
            isJumping = false;
            yVelocity = 0;
        }
        // 점프 구현
        if(Input.GetButtonDown("Jump") && !isJumping){
            yVelocity = jumpPower;
            isJumping = true;
        }

        // 캐릭터의 수직 속도에 중력값 적용
        yVelocity += gravity * Time.deltaTime; 
        dir.y = yVelocity; 

        // 이동 함수
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}
