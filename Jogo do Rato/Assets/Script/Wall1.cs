using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall1 : MonoBehaviour
{
    public GameObject myWall;
    public GameObject myKey;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Key")
        {
            myWall.gameObject.SetActive(false);
            Destroy(myKey);
        }
    }
}
