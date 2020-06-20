using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject UI;
    void Awake()
    {
        DontDestroyOnLoad(UI); //show score between scenes
    }
    
    void Update()
    {
        UI = GameObject.FindGameObjectWithTag("Score");
    }
}
