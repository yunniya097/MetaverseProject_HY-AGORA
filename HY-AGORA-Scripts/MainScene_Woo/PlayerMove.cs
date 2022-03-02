using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 4f;
    CharacterController cc; //컴포넌트 변수 가져옴
    float gravity = -20f; //중력 변수
    float yVelocity = 0; //수직 속력 변수
    public float jumpPower = 10f; //점프력 변수
    public bool isJumping = false; //점프 상태 변수

    // Start is called before the first frame update
    void Start()
    {
        //컴포넌트 받아옴
        cc = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //horizontal 좌우버튼, a,d버튼 , 반대는 vetical
        float v = Input.GetAxis("Vertical");

        //이동 방향 설정
        Vector3 dir = new Vector3(h, 0, v); //x축 좌우 점프, y축 점프, z축 앞뒤
        dir = dir.normalized; //정교화로 부드럽게 움직이기

        //메인 카메라를 기준으로 방향 변환하도록
        dir = Camera.main.transform.TransformDirection(dir);

        transform.position += dir * moveSpeed * Time.deltaTime; //이동속도에 맞춰 이동

        //점프 중이고 바닥에 착지했다면
        if (isJumping && cc.collisionFlags == CollisionFlags.Below) //collisionFlags 는 충돌을 감지 했나 안했나
        {
            isJumping = false;
            yVelocity = 0; //캐릭터 속도 0으로
        }


        //점프 구현
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            yVelocity = jumpPower;
            isJumping = true;
        }

        //캐릭터의 수직 속도에 중력 값을 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        //캐릭터 컨트롤러 이동 함수
        cc.Move(dir * moveSpeed * Time.deltaTime);

    }
}
