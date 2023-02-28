using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public int CoinNumber;
    [SerializeField] int TotalNumberCoins;

    [SerializeField] GameObject _activeWinText;
    [SerializeField] GameObject _inactiveCollectTextCoin;
    [SerializeField] GameObject _inactiveHealthText;

    private void WinText()
    {
        _activeWinText.SetActive(enabled);
        _inactiveCollectTextCoin.SetActive(enabled=false);
        _inactiveHealthText.SetActive(false);
    }
    private void Update()
    {
        if (CoinNumber >= TotalNumberCoins)
        {
            WinText();
        }
    }

}
