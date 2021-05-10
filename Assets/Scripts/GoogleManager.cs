using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleManager : MonoBehaviour
{
    Button loginbtn;
    Button logoutbtn;
    Button leaderBoardbtn;
    public HpSlider damage1;
    public HpSlider damage2;
    public HpSlider damage3;
    public HpSlider damage4;
    public HpSlider damage5;

    public int getDamage(HpSlider damage)
    {

        return (int)(damage.damUpaxefl + damage.damUpgoldfl + damage.damUpredfl + damage.damUpsilverfl);
    }

    void Awake()
    {
        PlayGamesPlatform.InitializeInstance(new PlayGamesClientConfiguration.Builder().Build());
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }
    void Start()
    {

        // loginbtn = GameObject.Find("logIn").GetComponent<Button>();
        // loginbtn.onClick.AddListener(OnLogin);

        // logoutbtn = GameObject.Find("logOut").GetComponent<Button>();
        // logoutbtn.onClick.AddListener(OnLogOut);

        // leaderBoardbtn = GameObject.Find("Ranking").GetComponent<Button>();
        // leaderBoardbtn.onClick.AddListener(OnShowLeaderBoard);
    }

    public void OnLogin()
    {
        if (!Social.localUser.authenticated)
        {
            Social.localUser.Authenticate((bool bSuccess) =>
            {
                if (bSuccess)
                {
                    Debug.Log("Success : " + Social.localUser.userName);
                }
                else
                {
                    Debug.Log("Login Fall");
                }
            });
        }
    }

    public void OnLogOut()
    {
        ((PlayGamesPlatform)Social.Active).SignOut();
        Debug.Log("LogOut");
    }

    public void OnShowLeaderBoard()
    {
        // 1000점을 등록
        float score = getDamage(damage1) + getDamage(damage2) + getDamage(damage3) + getDamage(damage4) + getDamage(damage5);
        Social.ReportScore((int)score, GPGSIds.leaderboard_ranking, (bool bSuccess) =>
        {
            if (bSuccess)
            {
                Debug.Log("ReportLeaderBoard Success");
            }
            else
            {
                Debug.Log("ReportLeaderBoard Fall");
            }
        }
        );
        Social.ShowLeaderboardUI();
    }
}