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
            "(으)로 캐릭터를 생성합니다.\n성별을 선택하세요.";
        //NameCompleteText.text =PlayerPrefs.GetString("Name") + " (으)로 캐릭터를 생성합니다.";
    }
}
