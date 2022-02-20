using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class PhotonManagers : MonoBehaviourPunCallbacks
{
    // 버전 입력
    private readonly string version = "1.0f"; 

    public Text StatusText;
    public InputField NickNameInput;
    public GameObject UIPanel;
    
    private bool connect = false;

    /*
    void Awake()
    {
        // 같은 룸의 유저들에게 자동으로 씬을 로딩
        PhotonNetwork.AutomaticallySyncScene = true;
        // 같은 버전의 유저끼리 접속 허용
        PhotonNetwork.GameVersion = version;
    }*/

    

   // 현재 상태 표시
   private void Update() => StatusText.text = PhotonNetwork.NetworkClientState.ToString();

   // 서버 접속
   public void Connect() => PhotonNetwork.ConnectUsingSettings();



    // 포톤 서버에 접속 후 호출되는 콜백 함수
    public override void OnConnectedToMaster()
    {

        print("서버접속완료");
        string nickName = PhotonNetwork.LocalPlayer.NickName;
        nickName = NickNameInput.text;
        print("당신의 이름은 " + nickName + " 입니다.");
        connect = true;
    }

    //연결 끊기
    public void Disconnect() => PhotonNetwork.Disconnect();
    //연결 끊겼을 때 호출
    public override void OnDisconnected(DisconnectCause cause) => print("연결끊김");

    // 로비 입장
    public void JoinLobby()
    {
        if(connect)
        {
            PhotonNetwork.JoinLobby();
            UIPanel.SetActive(false);
            print("아고라에 입장하셨습니다.");
        }
    }

    // 로비에 접속 후 호출되는 콜백 함수
    public override void OnJoinedLobby()
    {
        Debug.Log($"PhotonNetwork.InLobby = {PhotonNetwork.InLobby}");
    }
}
