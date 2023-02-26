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

    private void WinText()
    {
        _activeWinText.SetActive(enabled);
        _inactiveCollectTextCoin.SetActive(enabled=false);
    }
    private void Update()
    {
        if (CoinNumber >= TotalNumberCoins)
        {
            WinText();
        }
    }

}
