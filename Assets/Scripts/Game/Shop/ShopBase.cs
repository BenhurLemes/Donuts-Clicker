using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu]
public class ShopBase : ScriptableObject
{
    // Start is called before the first frame update

    #region Shop_Item
    public int shopprize;
    public int number;
    public int MoneyX;
    #endregion

    #region Amount_ITem
    public int amount;
    public float amountProfit;
    #endregion
}
