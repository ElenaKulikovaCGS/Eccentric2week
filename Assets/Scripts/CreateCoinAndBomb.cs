using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCoinAndBomb : MonoBehaviour
{
    [SerializeField] GameObject _prefabCoin;
    [SerializeField] int _totalNumberCoins;

    [SerializeField] GameObject _prefabBomb;
    [SerializeField] int _totalNumberBombs;

    [SerializeField] int _playingFieldLength;
    [SerializeField] int _playinFieldHeight;

    void Start()
    {
        for (int CreateCoin = 0; CreateCoin < _totalNumberCoins; CreateCoin++)
        {
            float x = Random.Range(-_playingFieldLength, _playingFieldLength);
            float y = Random.Range(-_playinFieldHeight, _playinFieldHeight);
            Instantiate(_prefabCoin, new Vector3(x, y), transform.rotation, transform);
        }
        for (int CreateBomb = 0; CreateBomb < _totalNumberBombs; CreateBomb++)
        {
            float x = Random.Range(-_playingFieldLength, _playingFieldLength);
            float y = Random.Range(-_playinFieldHeight, _playinFieldHeight);
            Instantiate(_prefabBomb, new Vector3(x, y), transform.rotation, transform);
        }
    }
}
