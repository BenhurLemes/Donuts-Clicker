using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    #region Click
    public float LimitedMoney;
    public float current_Money;
    public float hitpower;
    public float MoneyIncresedforSecond;
    public float x;
    public TMP_Text _textMoney;
    #endregion

    public void Clicked()
    {
        if (current_Money < LimitedMoney)
        {
            current_Money += hitpower;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        current_Money = 0;
        LimitedMoney = 1000;
        hitpower = 1;
        MoneyIncresedforSecond = 1;
        x = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _textMoney.text = "Money: R$" + Mathf.FloorToInt(current_Money).ToString();
        MoneyIncresedforSecond = x * Time.deltaTime;
        if(current_Money <= LimitedMoney)
        {
            current_Money += MoneyIncresedforSecond;
        }
        else
        {
            current_Money = LimitedMoney;
        }
    }
}
