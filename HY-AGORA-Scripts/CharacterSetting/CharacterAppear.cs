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
        /*남 캐릭터 활성화*/
        Male.SetActive(true);

        /*여 캐릭터 비활성화*/
        if (Female.activeSelf == true)
        {
            Female.SetActive(false);
        }
        
    }

    public void FemaleAppear()
    {
        isMale = false;
        Debug.Log("is female");
        /*여 캐릭터 활성화*/
        Female.SetActive(true);

        /*남 캐릭터 비활성화*/
        if (Male.activeSelf == true)
        {
            Male.SetActive(false);
        }
        
    }
}
