using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCoinAndBomb : MonoBehaviour
{
    [SerializeField] GameObject _coinPrefab;
    [SerializeField] GameObject _bombPrefab;

    [SerializeField] int _totalNumberCoins;
    [SerializeField] int _totalNumberBombs;

    [SerializeField] int _playingFieldLength;
    [SerializeField] int _playinFieldHeight;

    void Start()
    {
        for (int CreateCoin = 0; CreateCoin < _totalNumberCoins; CreateCoin++)
        {
            float x = Random.Range(-_playingFieldLength, _playingFieldLength);
            float y = Random.Range(-_playinFieldHeight, _playinFieldHeight);
            Instantiate(_coinPrefab, new Vector3(x, y), transform.rotation, transform);
        }
        for (int CreateBomb = 0; CreateBomb < _totalNumberBombs; CreateBomb++)
        {
            float x = Random.Range(-_playingFieldLength, _playingFieldLength);
            float y = Random.Range(-_playinFieldHeight, _playinFieldHeight);
            Instantiate(_bombPrefab, new Vector3(x, y), transform.rotation, transform);
        }
    }

    /*
    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            if (Random.Range(0,3) == 0)
            {
                if (Random.Range(0,3)==0)
                {
                    Vector3 positionBomb = new Vector3(Random.Range(-50f, 50f), Random.Range(-20f, 20f), 0f);
                    Instantiate(_bombPrefab, positionBomb, Quaternion.identity);
                }
                else
                {
                    Vector3 positionCoin = new Vector3(Random.Range(-50f, 50f), Random.Range(-20f, 20f), 0f);
                    Instantiate(_coinPrefab, positionCoin, Quaternion.identity);
                }
            }
        }
    }
    */
}
