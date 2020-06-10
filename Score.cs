using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject UI;
    void Awake()
    {
        DontDestroyOnLoad(UI);
    }

    // Update is called once per frame
    void Update()
    {
        UI = GameObject.FindGameObjectWithTag("Score");
    }
}
