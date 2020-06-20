using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;    
    private GameObject Plat;    
        

    private void OnTriggerEnter2D(Collider2D collision)
    {        
        Plat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-15f, 15f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        Destroy(collision.gameObject);        
        // Instantiate the platform then destroy after the player passed it 
    }
}
