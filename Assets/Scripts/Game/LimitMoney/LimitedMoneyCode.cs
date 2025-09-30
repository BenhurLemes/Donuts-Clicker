using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LimitedMoneyCode : MonoBehaviour
{
    [Header("Variáveis")]
    [SerializeField] LimitedMoneyBase LimitedMoneyBase;
    [SerializeField] GameManager Manager;
    [SerializeField] TMP_Text LimitedName;
    [SerializeField] Button ButtonLimited;
    [SerializeField] bool Buyed = false;

    private void Update()
    {
        Initial();
    }

    #region PRIVATES METHODS

    private void Initial()
    {
        LimitedName.text = "Cost: R$" + LimitedMoneyBase.getLimitPrize().ToString();
    }

    public void Limited()
    {
        if(Buyed == false)
        {
            if (Manager.getCurrentMoney() >= LimitedMoneyBase.getLimitPrize())
            {
                Manager.increseadCurrentMoney(-LimitedMoneyBase.getLimitPrize());
                Manager.setLimitedMoney(LimitedMoneyBase.getLimitIncreased());
                Buyed = true;
            }
            ButtonLimited.interactable = false;
        }
        else
        {
            return;
        }
    }
    #endregion
}
