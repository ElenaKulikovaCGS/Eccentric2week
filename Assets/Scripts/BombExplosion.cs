using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    [SerializeField] float _timeDistruct;
        public void Awake()
        {
            Destroy(gameObject, _timeDistruct);
        }
}
