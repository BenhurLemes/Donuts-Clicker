using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ShopCode : MonoBehaviour
{
    [Header("Variáveis privadas")]
    [SerializeField] ShopBase BaseShop;
    [SerializeField] GameManager GameManager;

    [Header("Variáveis Shop item")]
    [SerializeField] TMP_Text _textShopText;

    [Header("Variáveis Amount item")]
    [SerializeField] TMP_Text amountText;

    // Update is called once per frame
    private void Awake()
    {
        if(GameManager == null)
        {
            GameManager = FindAnyObjectByType<GameManager>();
        }
    }

    void Update()
    {
        Initial();
    }   

    private void Initial()
    {
        _textShopText.text = "Tier " + BaseShop.getNumber().ToString() + ": " + BaseShop.getShopPrize().ToString() + " $";
        amountText.text = "Tier " + BaseShop.getNumber().ToString() + ": " + BaseShop.getAmount().ToString() + " arts $: " + BaseShop.getAmountProfit().ToString() + "/s";
    }

    public void Shop()
    {
        if(GameManager.getCurrentMoney() >= BaseShop.getShopPrize())
        {
            GameManager.increseadCurrentMoney(-BaseShop.getShopPrize());
            BaseShop.IncreseadAmount();
            BaseShop.IncreseadAmountProfit();
            GameManager.increasedX(BaseShop.getMoneyX());
            BaseShop.IncreaseadPrize();
        }
    }
}
