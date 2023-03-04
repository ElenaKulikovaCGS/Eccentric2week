using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Biplane : MonoBehaviour
{
    [SerializeField] int _health;
    [SerializeField] int _damageBomb;

    [SerializeField] GameObject _lossText;
    [SerializeField] TextMeshProUGUI _healthText;
    [SerializeField] GameObject _inactiveHealthText;
    [SerializeField] GameObject _inactiveCollectText;

    [SerializeField] Score Score;
    private void Update()
    {
        string HealthText = "Жизни: " + _health;
        _healthText.text = HealthText;
    }

    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();

        if (bomb)
        {
            _health -= _damageBomb;
            bomb.Die();

            if (_health <=0)
            {
                gameObject.SetActive(false);
                _inactiveCollectText.SetActive(false);
                _inactiveHealthText.SetActive(false);
                _lossText.SetActive(enabled);
            }
        }

        Coin coin = other.gameObject.GetComponent<Coin>();
         if (coin)
        {
            coin.Die();
            Score.AddCoin();
        }
    }
}
