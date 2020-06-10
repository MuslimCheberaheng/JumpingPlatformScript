using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class TrapInst : MonoBehaviour
{
    public GameObject player;
    public GameObject TrapPrefab;
    private GameObject trap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        trap = (GameObject)Instantiate(TrapPrefab, new Vector2(Random.Range(-17.5f, 17.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        Destroy(collision.gameObject);
        
    }
}
