using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public Transform prefab;
    //public GameObject prefab2;

    private void Start()
    {
        GetComponent<ScoreTextScript>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
            ScoreTextScript.coinAmount += 1;
            Destroy(gameObject);
           // Vector3 pos = new Vector3(Random.Range(-5, 8), Random.Range(4, 0), Random.Range(0, 0));
           // Transform objectInstance = Instantiate(prefab, pos, Quaternion.identity);
           // GameObject objectInstance2 = Instantiate(prefab2, pos, Quaternion.identity);
           // Destroy(objectInstance2);
    }
}