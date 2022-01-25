using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private new Transform transform;
    private Animator animator;
    private new Camera camera;

    // 가상의 plane에 레이캐스팅하기 위한 변수
    private Plane plane;
    private Ray ray;
    private Vector3 hitPoint;

    // 이동 속도
    public float moveSpeed = 10.0f; 

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); // controller에 CharacterController 컴포넌트 가져오기
        transform = GetComponent<Transform>(); // transform에 Transform 컴포넌트 가져오기
        animator = GetComponent<Animator>(); // animator에 Animator 컴포넌트 가져오기
        camera = Camera.main; // 카메라는 컴포넌트로 가저오지 x

        // 가상의 바닥을 기준으로 주인공의 위치를 생성
        plane = new Plane(transform.up, transform.position); // new Plane -> 새로운 plane 생성, () 안에 plane이 생성되는 위치 지정, 
                                                            // transform.position -> transform의 위치에 주인공의 위치 생성을 위해 transform이 위치해 있는 position 값 가져옴

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Turn();
    }

    float h => Input.GetAxis("Horizontal"); // input.getaxis -> unity edit 메뉴 project setting에 존재
    float v => Input.GetAxis("Vertical");

    // Move 함수 생성
    void Move()
    {
        Vector3 cameraForward = camera.transform.forward; // 3차원 공간(vector3) 앞뒤 이동 
        Vector3 cameraRight = camera.transform.right; // 3차원 공간(vector3) 양옆 이동
        cameraForward.y = 0.0f; // cameraforward 변수의 y축 선언, cameraforward. -> 변수의 아래 속성
        cameraRight.y = 0.0f;

        // 이동할 방향 벡터 계산
        Vector3 moveDir = (cameraForward * v) + (cameraRight * h); // camera가 어떻게 이동할지 선언
        moveDir.Set(moveDir.x, 0.0f, moveDir.z);

        // 캐릭터 이동 처리
        controller.SimpleMove(moveDir * moveSpeed);

        // 캐릭터 애니메이션 처리
        float forward = Vector3.Dot(moveDir, transform.forward);
        float strafe = Vector3.Dot(moveDir, transform.right);
        animator.SetFloat("Forward", forward);
        animator.SetFloat("Strafe", strafe);
    }

    // Turn 함수 생성
    void Turn()
    {
        // 마우스의 2차원 좌푯값을 이용해 3차원 레이를 생성
        ray = camera.ScreenPointToRay(Input.mousePosition);
        float enter = 0.0f;

        // 가상의 바닥에 ray를 발사해 충돌 지점의 거리를 enter 변수로 반환
        plane.Raycast(ray, out enter);

        // 가상의 바닥에 레이가 충돌한 좌푯값을 추출
        hitPoint = ray.GetPoint(enter);

        // 회전해야 할 방향의 벡터를 계산
        Vector3 lookDir = hitPoint - transform.position;
        lookDir.y = 0;

        // 캐릭터의 회전값 지정
        transform.localRotation = Quaternion.LookRotation(lookDir);
    }
}
