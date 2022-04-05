using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NicknameInput : MonoBehaviour
{

    public InputField inputName;

    public GameObject Object;
    public void Confirm()
    {
        Object.SetActive(true);
    }
    public void Save()
    {
        PlayerPrefs.SetString("Name", inputName.text);
        Debug.Log("save " + PlayerPrefs.GetString("Name"));
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            inputName.text = PlayerPrefs.GetString("Name");
        }
    }

}
