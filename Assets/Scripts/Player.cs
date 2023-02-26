using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int Health;
    [SerializeField] GameObject _lossText;
    TextMeshProUGUI _healthText;
    [SerializeField] GameObject _inactiveHealthText;
    [SerializeField] GameObject _inactiveCollectText;

    void LossText()
    {
        _lossText.SetActive(enabled);
    }
    private void Start()
    {
        _healthText = FindAnyObjectByType<HealthText>().GetComponent<TextMeshProUGUI>();
        
    }
    private void Update()
    {
        _healthText.text = "Жизни: " + Health;
        if (Health <= 0)
        {
            LossText();
            gameObject.SetActive(false);
            _inactiveCollectText.SetActive(false);
            _inactiveHealthText.SetActive(false);

        }
    }
}
