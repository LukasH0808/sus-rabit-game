using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = GameObject.Find("PlayerObj").GetComponent<GameObject>();
    }
    private void OnCollisionEnter()
    {
        Destroy(GameObject);
    }
}
