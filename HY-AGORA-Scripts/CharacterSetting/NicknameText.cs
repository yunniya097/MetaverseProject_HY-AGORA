using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NicknameText : MonoBehaviour
{
    public Text NameCompleteText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("Name"));
        NameCompleteText.text ="\"" +PlayerPrefs.GetString("Name")+ "\"" +
            "(��)�� ĳ���͸� �����մϴ�.\n������ �����ϼ���.";
        //NameCompleteText.text =PlayerPrefs.GetString("Name") + " (��)�� ĳ���͸� �����մϴ�.";
    }
}
