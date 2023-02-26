using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    [SerializeField] float _rotateSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }
}
