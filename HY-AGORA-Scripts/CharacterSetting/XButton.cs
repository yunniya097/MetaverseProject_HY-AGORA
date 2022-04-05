using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButton : MonoBehaviour
{
    public GameObject Object;

    public void Close()
    {
        Object.SetActive(false);
    }
}
