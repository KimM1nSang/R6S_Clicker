using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    public GameObject upgradeui;
    public GameObject shopui;
    public GameObject menuset;
    public GameObject hj;
    public void UpgradeUI()
    {
        if(upgradeui.activeSelf)
        {
            upgradeui.SetActive(false);
        }
        else
        {
            upgradeui.SetActive(true);
        }
    }
    public void ShopUI()
    {
        if(shopui.activeSelf||menuset.activeSelf)
        {
            shopui.SetActive(false);
        }
        else
        {
            shopui.SetActive(true);
        }
    }
    public void MenuOn()
    {
        if(menuset.activeSelf||shopui.activeSelf)
        {
            menuset.SetActive(false);
        }
        else
        {
            menuset.SetActive(true);
        }
    }
    public void Honeyjam()
    {

        if (hj.activeSelf)
        {
            hj.SetActive(false);
        }
        else
        {
            hj.SetActive(true);
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
}
