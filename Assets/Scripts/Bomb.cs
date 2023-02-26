using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<Player>().Health -= 10;
        GetComponent<Animator>().enabled = true;
        GetComponent<Animator>().Play("Explosion");
        Destroy(gameObject, 1f);
    }
}
