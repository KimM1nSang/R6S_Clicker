using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ShopAndUpgrade : Singleton<ShopAndUpgrade>
{
    public List<long> UpgradePriceList = new List<long>();
    public List<long> UpgradePriceEarnList = new List<long>();

    ChangeImage chImage;
    public GameObject bedsellclear = null;
    public GameObject dollsellclear = null;
    public GameObject BBG = null;
    public GameObject PCsellclear = null;

    private void Start()
    {
        chImage = FindObjectOfType<ChangeImage>();
    }

    public void Upgrade()
    {
        if (GameManager.Instance.gameData.needmoney <= GameManager.Instance.gameData.curmoney)
        {
            GameManager.Instance.gameData.curmoney -= GameManager.Instance.gameData.needmoney;
            int ran = UnityEngine.Random.Range(0, 50);
            int a = 0;
            if (ran == 0)
            {
                if (GameManager.Instance.gameData.needmoney > 1)
                {
                    if (a >= UpgradePriceEarnList.Count) // 업그레이드가 최대로 찍혔는지 감지
                    {
                        GameManager.Instance.gameData.earnmoney -= 100 + a * 10;
                        GameManager.Instance.gameData.needmoney -= 100 + a * 10;
                    }
                    else
                    {
                        GameManager.Instance.gameData.earnmoney -= UpgradePriceEarnList[a];
                        GameManager.Instance.gameData.needmoney -= UpgradePriceList[a];
                    }
                    a--;
                    Debug.Log("실패1");
                }
                else
                {
                    Debug.Log("실패2");
                }
            }
            else
            {
                if (a >= UpgradePriceEarnList.Count) // 업그레이드가 최대로 찍혔는지 감지
                {
                    GameManager.Instance.gameData.earnmoney += 100 + a * 10;
                    GameManager.Instance.gameData.needmoney += 100 + a * 10;
                }
                else
                {
                    GameManager.Instance.gameData.earnmoney += UpgradePriceEarnList[a];
                    GameManager.Instance.gameData.needmoney += UpgradePriceList[a];
                }
                a++;
                Debug.Log("성공");
            }
        }
        else
        {

        }
    }
    public void AutoUpgrade()
    {
        if (GameManager.Instance.gameData.autoneed <= GameManager.Instance.gameData.curmoney)
        {
            GameManager.Instance.gameData.curmoney -= GameManager.Instance.gameData.autoneed;
            int ran = UnityEngine.Random.Range(0, 50);
            int a = 0;
            if (ran == 0)
            {
                if (GameManager.Instance.gameData.autoneed > 2)
                {
                    if (a >= UpgradePriceEarnList.Count) // 업그레이드가 최대로 찍혔는지 감지
                    {
                        GameManager.Instance.gameData.autoMoney -= 100 + a*3;
                        GameManager.Instance.gameData.autoneed -= 100 + a*3;
                    }
                    else
                    {
                        GameManager.Instance.gameData.autoMoney -= UpgradePriceEarnList[a];
                        GameManager.Instance.gameData.autoneed -= UpgradePriceList[a];
                    }
                    a--;
                    Debug.Log("실패1");
                }
                else
                {
                    Debug.Log("실패2");
                }
            }
            else
            {
                if (a >= UpgradePriceEarnList.Count) // 업그레이드가 최대로 찍혔는지 감지
                {
                    GameManager.Instance.gameData.autoMoney += 100 + a * 3;
                    GameManager.Instance.gameData.autoneed += 100 + a * 3;
                }
                else
                {
                    GameManager.Instance.gameData.autoMoney += UpgradePriceEarnList[a];
                    GameManager.Instance.gameData.autoneed += UpgradePriceList[a];
                }
                a++;
                Debug.Log("성공");
            }
        }
    }
    public void Buybed()
    {
        if (GameManager.Instance.gameData.bedbuyMoney <= GameManager.Instance.gameData.curmoney)
        {
            GameManager.Instance.gameData.curmoney -= GameManager.Instance.gameData.bedbuyMoney;
            GameManager.Instance.gameData.earnmoney += 7;
            bedsellclear.SetActive(true);
        }
    }
    public void Buydoll()
    {
        if (GameManager.Instance.gameData.dollbuyMoney <= GameManager.Instance.gameData.curmoney)
        {
            GameManager.Instance.gameData.curmoney -= GameManager.Instance.gameData.dollbuyMoney;
            GameManager.Instance.gameData.earnmoney += 7;
            dollsellclear.SetActive(true);
            BBG.SetActive(true);
        }
    }
    public void BuyPC()
    {
        if (GameManager.Instance.gameData.chbuyMoney <= GameManager.Instance.gameData.curmoney)
        {
            GameManager.Instance.gameData.curmoney -= GameManager.Instance.gameData.chbuyMoney;
            GameManager.Instance.gameData.earnmoney += 7;
            chImage.Change();
            PCsellclear.SetActive(true);
        }
    }
}
