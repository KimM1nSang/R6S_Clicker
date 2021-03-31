using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameData
{
    [Header("숙성일")]
    [SerializeField]
    public long curmoney = 0;

    [Header("아이템구매")]
    [SerializeField]
    public long bedbuyMoney = 200;
    [SerializeField]
    public long dollbuyMoney = 200;
    [SerializeField]
    public long chbuyMoney = 200;

    [Header("업그레이드")]
    [SerializeField]
    public long needmoney = 10;
    [SerializeField]
    public long earnmoney = 1;

    [SerializeField]
    public long autoMoney = 0;
    [SerializeField]
    public long autoneed = 10;

    public enum SETTYPE
    {
        SET,
        ADD,
        REMOVE,
    };

    public void AccessSetMoney(SETTYPE settype, long value)
    {
        switch (settype)
        {
            case SETTYPE.SET: curmoney = value; break;
            case SETTYPE.ADD: curmoney += value; break;
            case SETTYPE.REMOVE: curmoney -= value; break;
        }
    }
    public long AccessGetMoney()
    {
        return curmoney;
    }
}