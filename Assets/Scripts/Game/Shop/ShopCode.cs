using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ShopCode : MonoBehaviour
{
    public ShopBase BaseShop;
    public GameManager GameManager;

    #region Shop_Item
    public TMP_Text _textShopText;
    #endregion

    #region Amount_ITem
    public TMP_Text amountText;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Initial();
    }

    private void Initial()
    {
        _textShopText.text = "Tier " + BaseShop.number.ToString() + ": " + BaseShop.shopprize.ToString() + " $";
        amountText.text = "Tier " + BaseShop.number.ToString() + ": " + BaseShop.amount.ToString() + " arts $: " + BaseShop.amountProfit.ToString() + "/s";
    }

    public void Shop()
    {
        if(GameManager.current_Money >= BaseShop.shopprize)
        {
            GameManager.current_Money -= BaseShop.shopprize;
            BaseShop.amount += 1;
            BaseShop.amountProfit += 1;
            GameManager.x += BaseShop.MoneyX;
            BaseShop.shopprize *= 2;
        }
    }
}
