using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAppear : MonoBehaviour
{
    public GameObject Male;

    public GameObject Female;

    [SerializeField]
    public static bool isMale = true;

    public void MaleAppear()
    {
        isMale = true;
        /*�� ĳ���� Ȱ��ȭ*/
        Male.SetActive(true);

        /*�� ĳ���� ��Ȱ��ȭ*/
        if (Female.activeSelf == true)
        {
            Female.SetActive(false);
        }
        
    }

    public void FemaleAppear()
    {
        isMale = false;
        Debug.Log("is female");
        /*�� ĳ���� Ȱ��ȭ*/
        Female.SetActive(true);

        /*�� ĳ���� ��Ȱ��ȭ*/
        if (Male.activeSelf == true)
        {
            Male.SetActive(false);
        }
        
    }
}
