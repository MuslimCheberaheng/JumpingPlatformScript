using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    public float TrapSpeed;    

    void Update()
    {
        transform.Rotate(0, 0, TrapSpeed); //to spin the trap
    }    
}
