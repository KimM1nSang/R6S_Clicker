using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Touch : MonoBehaviour
{
    public Text Money = null;
    [SerializeField]
    private Text need = null;
    [SerializeField]
    private Text earn = null;
    public Text Auto = null;
    [SerializeField]
    private Text Autoneed = null;
   
    private void Start()
    {
        UpdateUpgrade();
        InvokeRepeating("AutoMoney",0,1);
    }

    private void Update()
    {
        UpdateUpgrade();
    }
    public void Givemoney()
    {
        GameManager.Instance.gameData.AccessSetMoney(GameData.SETTYPE.ADD, GameManager.Instance.gameData.earnmoney);
    }
    public void UpdateUpgrade()
    {

        //money.text = money.ToString();
        //need.text = sag.needmoney.ToString();
        need.text = string.Format("필요날짜 : {0:D} 일", GameManager.Instance.gameData.needmoney);
        //earn.text = earnmoney.ToString();
        earn.text = string.Format("숙성증가 : {0:D} 일", GameManager.Instance.gameData.earnmoney);

        Auto.text = string.Format("자동증가 : {0:f0} 일", GameManager.Instance.gameData.autoMoney);

        Autoneed.text = string.Format("필요날짜 : {0:D} 일", GameManager.Instance.gameData.autoneed);

        //Money.text = string.Format("밥버거 : {0:f0} 일", curmoney);
        long money = GameManager.Instance.gameData.AccessGetMoney();
        string money_t = "";
        if (money >= 100000000)
            money_t += string.Format("{0}억", (GameManager.Instance.gameData.curmoney % 1000000000000) / 100000000);
        if (money >= 10000)
            money_t += string.Format("{0}만", (GameManager.Instance.gameData.curmoney % 100000000) / 10000);
        if (money >= 0)
            money_t += string.Format("{0}일", GameManager.Instance.gameData.curmoney % 10000);
        Money.text = money_t;

    }
    private void AutoMoney()
    {
        GameManager.Instance.gameData.AccessSetMoney(GameData.SETTYPE.ADD, GameManager.Instance.gameData.autoMoney);
    }
}
