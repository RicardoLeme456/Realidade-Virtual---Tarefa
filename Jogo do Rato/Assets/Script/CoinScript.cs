using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void Start()
    {
        GetComponent<ScoreTextScript>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
            ScoreTextScript.coinAmount += 1;
            Destroy(gameObject);
    }
}