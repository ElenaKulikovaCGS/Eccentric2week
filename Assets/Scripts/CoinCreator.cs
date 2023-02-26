using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreator : MonoBehaviour
{
    [SerializeField] GameObject _prefabCoin;
    [SerializeField] int _totalNumberCoins;
    [SerializeField] int _playingFieldLength;
    [SerializeField] int _playinFieldHeight;

    void Start()
    {
        for (int CoinCreator = 0; CoinCreator < _totalNumberCoins; CoinCreator++)
        {
            float x = Random.Range(-_playingFieldLength, _playingFieldLength);
            float y = Random.Range(-_playinFieldHeight, _playinFieldHeight);
            Instantiate(_prefabCoin, new Vector3(x, y), transform.rotation, transform);
        }
    }
}
