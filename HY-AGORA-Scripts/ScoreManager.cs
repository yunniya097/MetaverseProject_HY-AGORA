using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject scorePanel0;
    public GameObject scorePanel1;
    public GameObject scorePanel2;
    public GameObject scorePanel3;
    public GameObject scorePanel4;
    public GameObject scorePanel5;

    public GameObject winPanel;
    public GameObject losePanel;

    GameObjClick gm;

    void Awake()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);
        
        scorePanel0.SetActive(false);
        scorePanel1.SetActive(false);
        scorePanel2.SetActive(false);
        scorePanel3.SetActive(false);
        scorePanel4.SetActive(false);
        scorePanel5.SetActive(false);
    }

    public void scorePanel0On()
    {
        scorePanel0.SetActive(true);
    }
    public void scorePanel0Off()
    {
        scorePanel0.SetActive(false);
    }

    public void scorePanel1On()
    {
        scorePanel1.SetActive(true);
    }
    public void scorePanel1Off()
    {
        scorePanel1.SetActive(false);
    }

    public void scorePanel2On()
    {
        scorePanel2.SetActive(true);
    }
    public void scorePanel2Off()
    {
        scorePanel2.SetActive(false);
    }

    public void scorePanel3On()
    {
        scorePanel3.SetActive(true);
    }public void scorePanel3Off()
    {
        scorePanel3.SetActive(false);
    }


    public void scorePanel4On()
    {
        scorePanel4.SetActive(true);
    }
    public void scorePanel4Off()
    {
        scorePanel4.SetActive(false);
    }

    public void scorePanel5On()
    {
        scorePanel5.SetActive(true);
    }
    public void scorePanel5Off()
    {
        scorePanel5.SetActive(false);
    }

    public void LosePanelOn()
    {
        scorePanel5.SetActive(false);
        losePanel.SetActive(true);
    }

    public void LosePanelOff()
    {
        losePanel.SetActive(false);
    }

    public void WinPanelOn()
    {
        scorePanel5.SetActive(false);
        winPanel.SetActive(true);
        /*임시*/
        GameObject.Find("HanyangGame").SetActive(false);
    }

    public void WinPanelOff()
    {
        winPanel.SetActive(false);
    }
    /*public static int score;
    
    public GameObject GameManager;
    public Text gameTxt;

    bool scoreOn;

    private Text txt; // score가 표시될 text

    void Awake()
    {
        txt = GetComponent<Text>();
        objt = GameManager.GetComponent<GameObjClick>();

        score = 0;
        scoreOn = false;
        gameoverPanel.SetActive(false);
        text.SetActive(false);
    }

    void Update()
    {
        if()
        txt.text = "Score: " + objt.score;
    }

    public void GameOver()
    {
        gameoverPanel.SetActive(true);
        gameTxt.text = "Your score: " + objt.score;
    }

    public void ScoreStart()
    {
        scoreOn = true;
    }

    public void ScoreStop()
    {
        scoreOn = false;
    }
    */
}
