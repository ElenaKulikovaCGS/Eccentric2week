using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] int _coins;
    [SerializeField] int _addCoins;
    [SerializeField] TextMeshProUGUI CoinsText;

    [SerializeField] int _totalNumberCoins;

    [SerializeField] GameObject _activeWinText;
    [SerializeField] GameObject _inactiveCollectTextCoin;
    [SerializeField] GameObject _inactiveHealthText;
    [SerializeField] GameObject _inactiveCollectTextShadow;
    [SerializeField] GameObject _inactiveTargetIcon;
    [SerializeField] Rigidbody _player;
    [SerializeField] GameObject _playerCollider;

    public void AddCoin()
    {
        _coins += _addCoins;
        CoinsText.GetComponent<TextMeshProUGUI>().text = "Собрано монет: " + _coins.ToString();
        if (_coins >= _totalNumberCoins)
        {
            Win();
        }
    }
    private void Win()
    {
        _activeWinText.SetActive(enabled);
        _inactiveCollectTextCoin.SetActive(enabled = false);
        _inactiveHealthText.SetActive(false);
        _inactiveCollectTextShadow.SetActive(false);
        _inactiveTargetIcon.SetActive(false);
        _player.drag = 50f;
        _player.angularDrag = 50f;
        _playerCollider.SetActive(false);
    }
}
