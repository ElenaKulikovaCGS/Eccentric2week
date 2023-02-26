using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Coin : MonoBehaviour
{
    [SerializeField] float _rotateSpeed;
    [SerializeField] float _addRotateSpeed;
    private float _randomRotateSpeed;

    int _coinNumberText;

    void CollisionCoin()
    {
        Destroy(gameObject);
        _coinNumberText = FindObjectOfType<CoinCounter>().CoinNumber += 1;
        FindObjectOfType<CoinCollectText>().GetComponent<TextMeshProUGUI>().text="Собрано монет: "+ _coinNumberText;
        
    }
    private void Start()
    {
        _randomRotateSpeed = Random.Range(-_addRotateSpeed, _randomRotateSpeed);
    }

    void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * _randomRotateSpeed * Time.deltaTime);

    }

    void OnCollisionEnter(Collision collision)
    {
        CollisionCoin();
    }
}
