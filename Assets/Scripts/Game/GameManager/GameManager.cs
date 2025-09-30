using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Variáveis jogo")]
    [SerializeField] float LimitedMoney;
    [SerializeField] float current_Money;
    [SerializeField] float hitpower;
    [SerializeField] float MoneyIncresedforSecond;
    [SerializeField] float x;
    [SerializeField] TMP_Text _textMoney;
    [SerializeField] Button Button;

    #region UNITY METHODS
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
        if (current_Money <= LimitedMoney)
        {
            current_Money += MoneyIncresedforSecond;
        }
        else
        {
            current_Money = LimitedMoney;
        }
    }
    #endregion

    #region PRIVATE METHODS
    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ButtonClicked()
    {
        StartCoroutine(ButtonClickAniamtion());
    }

    public void Clicked()
    {
        if (current_Money < LimitedMoney)
        {
            current_Money += hitpower;
        }
    }

    private IEnumerator ButtonClickAniamtion()
    {
        Button.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        yield return new WaitForSeconds(0.1f);
        Button.transform.localScale = new Vector3(1f, 1f, 1f);
        Clicked();
    }
    #endregion

    #region GETTERS AND SETTERS

    public void increseadHitPower(float power)
    {
        hitpower *= power;
    }

    public void increasedX(float y)
    {
        x += y;
    }

    public float getLimitedMoney()
    {
        return LimitedMoney;
    }

    public void setLimitedMoney(float limit)
    {
        LimitedMoney = limit;
    }

    public float getCurrentMoney()
    {
        return current_Money;
    }

    public void increseadCurrentMoney(float money)
    {
        current_Money += money;
    }
    #endregion
}