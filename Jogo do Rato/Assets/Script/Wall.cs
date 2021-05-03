using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject myWall;
    public GameObject myKey;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ball")
        {
            myWall.gameObject.SetActive(false);
            Destroy(myKey);
        }
    }
}
