using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class UpgradeBase : ScriptableObject
{

    [SerializeField] int UpgradePrize;
    [SerializeField] int UpgradePower;

    #region GETTERS AND SETTERS
    public int getUpgradePrize()
    {
        return UpgradePrize;
    }

    public int getUpgradePower()
    {
        return UpgradePower;
    }
    #endregion
}
