using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject player; // 바라볼 플레이어 오브젝트
    
    public float xmove = 0;  // X축 누적 이동량
    public float ymove = 0;  // Y축 누적 이동량

    // 회전 속도 변수
    public float rotSpeed = 200f;

    float mx = 0;
    float my = 0;

    public float distance = 3;

    public float SmoothTime = 0.2f;
    private Vector3 velocity = Vector3.zero;

    private int toggleView = 3; // 1=1인칭, 3=3인칭


    void Start()
    {
        if (CharacterAppear.isMale == true)
        {
            player = GameObject.Find("Player_Boy");
            GameObject.Find("player_girl").SetActive(false);
        }
        else
        {
            player = GameObject.Find("player_girl");
            GameObject.Find("Player_Boy").SetActive(false);
        }
    }


    void Update()
    {
        xmove += Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime; // 마우스의 좌우 이동량을 xmove에 누적
        ymove -= Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime; // 마우스의 상하 이동량을 ymove에 누적
        /*xmove += Input.GetAxis("Mouse X"); // 마우스의 좌우 이동량을 xmove에 누적
        ymove -= Input.GetAxis("Mouse Y"); // 마우스의 상하 이동량을 ymove에 누적*/

        ymove = Mathf.Clamp(ymove, -90f, 90f); //(대상, 최소, 최대)
        transform.rotation = Quaternion.Euler(ymove, xmove, 0); // 이동량에 따라 카메라의 바라보는 방향을 조정합니다.

        // 회전 값 변수에 마우스 입력 값 누적
        //mx += xmove * rotSpeed * Time.deltaTime;
        //my += ymove * rotSpeed * Time.deltaTime;

        // 마우스 상하 이동 회전 변수 값을 제한
        //my = Mathf.Clamp(my, -90f, 90f);

        //transform.RotateAround(player.transform.position, Vector3.up, 10f); // 이동량에 따라 카메라의 바라보는 방향을 조정

        // transform.eulerAngles = new Vector3(-my,mx, 0);
        
        // 의자 오브젝트 클릭 시 토글뷰를 1로 변환
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.gameObject.tag == "Table")
                {
                    Debug.Log("HIT Table");
                    toggleView = 4 - toggleView;
                }
            }
        }
        
        // 토글 뷰가 1이면 1인칭 시점
        if (toggleView == 1)
        {
            Vector3 reverseDistance = new Vector3(0.0f, 0.4f, 0.2f); // 카메라가 바라보는 앞방향은 Z 축입니다. 이동량에 따른 Z 축방향의 벡터를 구합니다.
            transform.position = player.transform.position + transform.rotation * reverseDistance; // 플레이어의 위치에서 카메라가 바라보는 방향에 벡터값을 적용한 상대 좌표를 차감합니다.
        }
        // 토글 뷰가 3이면 3인칭 시점
        else if (toggleView == 3)
        {
            /*Vector3 reverseDistance = new Vector3(0.0f, 0.0f, distance); // 카메라가 바라보는 앞방향은 Z 축입니다. 이동량에 따른 Z 축방향의 벡터를 구합니다.*/
            Vector3 reverseDistance = new Vector3(0.0f, -1.5f, distance); // 카메라가 바라보는 앞방향은 Z 축입니다. 이동량에 따른 Z 축방향의 벡터를 구합니다.
            transform.position = player.transform.position - transform.rotation * reverseDistance; // 플레이어의 위치에서 카메라가 바라보는 방향에 벡터값을 적용한 상대 좌표를 차감합니다.
        }
    }
}