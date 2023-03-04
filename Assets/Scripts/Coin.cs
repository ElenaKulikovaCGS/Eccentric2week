using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Coin : MonoBehaviour
{
    [SerializeField] float _rotateSpeed;
    [SerializeField] float _addRotateSpeed;
    private float _randomRotateSpeed;

    [SerializeField] GameObject _dieEffectPrefab;

    private void Start()
    {
        _randomRotateSpeed = Random.Range(-_addRotateSpeed, _randomRotateSpeed);
    }

    void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * _randomRotateSpeed * Time.deltaTime);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
