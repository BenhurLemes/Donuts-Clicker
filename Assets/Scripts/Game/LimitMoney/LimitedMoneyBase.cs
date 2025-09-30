using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LimitedMoneyBase : ScriptableObject
{
    [Header("Variáveis")]
    [SerializeField] float LimitIncreased;
    [SerializeField] int LimitPrize;


    #region GETTERS AND SETTERS
    public float getLimitIncreased() {
        return LimitIncreased;
    }

    public int getLimitPrize() {
        return LimitPrize;
    }
    #endregion
}
