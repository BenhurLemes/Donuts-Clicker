using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpgradeCode : MonoBehaviour
{
    public GameManager manager;
    public UpgradeBase upgrade;
    public TMP_Text UpgradeName;
    public bool Buyed = false;

    // Update is called once per frame
    void Update()
    {
        initial();
    }

    private void initial()
    {
        UpgradeName.text = "Cost: R$" + upgrade.UpgradePrize;
    }

    public void Upgrade()
    {
        if (Buyed == false)
        {
            if (manager.current_Money >= upgrade.UpgradePrize)
            {
                manager.current_Money -= upgrade.UpgradePrize;
                manager.hitpower *= upgrade.UpgradePower;
                Buyed = true;
            }
        }
        else
        {
            return;
        }
    }
}
