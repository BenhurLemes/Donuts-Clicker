using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LimitedMoneyCode : MonoBehaviour
{
    public LimitedMoneyBase LimitedMoneyBase;
    public GameManager Manager;
    public TMP_Text LimitedName;
    public bool Buyed = false;

    private void Update()
    {
        Initial();
    }
    private void Initial()
    {
        LimitedName.text = "Cost: R$" + LimitedMoneyBase.LimitPrize;
    }

    public void Limited()
    {
        if(Buyed == false)
        {
            if (Manager.current_Money >= LimitedMoneyBase.LimitPrize)
            {
                Manager.current_Money -= LimitedMoneyBase.LimitPrize;
                Manager.LimitedMoney = LimitedMoneyBase.LimitIncreased;
                Buyed = true;
            }
        }
        else
        {
            return;
        }
    }
}
