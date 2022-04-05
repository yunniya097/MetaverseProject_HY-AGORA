using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 4f;
    CharacterController cc; //������Ʈ ���� ������
    float gravity = -20f; //�߷� ����
    float yVelocity = 0; //���� �ӷ� ����
    public float jumpPower = 10f; //������ ����
    public bool isJumping = false; //���� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        //������Ʈ �޾ƿ�
        cc = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //horizontal �¿��ư, a,d��ư , �ݴ�� vetical
        float v = Input.GetAxis("Vertical");

        //�̵� ���� ����
        Vector3 dir = new Vector3(h, 0, v); //x�� �¿� ����, y�� ����, z�� �յ�
        dir = dir.normalized; //����ȭ�� �ε巴�� �����̱�

        //���� ī�޶� �������� ���� ��ȯ�ϵ���
        dir = Camera.main.transform.TransformDirection(dir);

        transform.position += dir * moveSpeed * Time.deltaTime; //�̵��ӵ��� ���� �̵�

        //���� ���̰� �ٴڿ� �����ߴٸ�
        if (isJumping && cc.collisionFlags == CollisionFlags.Below) //collisionFlags �� �浹�� ���� �߳� ���߳�
        {
            isJumping = false;
            yVelocity = 0; //ĳ���� �ӵ� 0����
        }


        //���� ����
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            yVelocity = jumpPower;
            isJumping = true;
        }

        //ĳ������ ���� �ӵ��� �߷� ���� ����
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        //ĳ���� ��Ʈ�ѷ� �̵� �Լ�
        cc.Move(dir * moveSpeed * Time.deltaTime);

    }
}
