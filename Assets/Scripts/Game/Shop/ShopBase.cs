using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu]
public class ShopBase : ScriptableObject
{
    // Start is called before the first frame update

    [Header("Variáveis Shop item")]
    [SerializeField] int shopprize;
    [SerializeField] int number;
    [SerializeField] int MoneyX;

    [Header("Variáveis Amount item")]
    [SerializeField] int amount;
    [SerializeField] float amountProfit;

    #region GETTERS AND SETTERS
    public int getShopPrize()
    {
        return shopprize;
    }

    public int getNumber()
    {
        return number;
    }

    public int getMoneyX()
    {
        return MoneyX;
    }

    public int getAmount()
    {
        return amount;
    }

    public float getAmountProfit()
    {
        return amountProfit;
    }

    public void IncreseadAmount()
    {
        amount++;
    }

    public void IncreseadAmountProfit()
    {
        amountProfit++;
    }

    public void IncreaseadPrize()
    {
        shopprize *= 2;
    }
    #endregion
}
