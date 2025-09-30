using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpgradeCode : MonoBehaviour
{
    [SerializeField] GameManager manager;
    [SerializeField] UpgradeBase upgrade;
    [SerializeField] TMP_Text UpgradeName;
    [SerializeField] bool Buyed = false;
    [SerializeField] Button ButtonLimited;

    // Update is called once per frame
    void Update()
    {
        initial();
    }

    private void initial()
    {
        UpgradeName.text = "Cost: R$" + upgrade.getUpgradePrize();
    }

    public void Upgrade()
    {
        if (Buyed == false)
        {
            if (manager.getCurrentMoney() >= upgrade.getUpgradePrize())
            {
                manager.increseadCurrentMoney(-upgrade.getUpgradePrize());
                manager.increseadHitPower(upgrade.getUpgradePower());
                Buyed = true;
            }
            ButtonLimited.interactable = false;
        }
        else
        {
            return;
        }
    }
}
