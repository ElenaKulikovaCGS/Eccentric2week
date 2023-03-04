using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] GameObject _dieEffectPrefab;
    public void Die()
    {
        Instantiate(_dieEffectPrefab, transform.position, Quaternion.identity);
        GetComponent<Animator>().enabled = true;
        GetComponent<Animator>().Play("Explosion");
        Destroy(gameObject, 1f);
    }
}
