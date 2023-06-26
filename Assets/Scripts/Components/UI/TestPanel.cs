using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestPanel : MonoBehaviour
{
    public Button btnAdd;
    public Button btnSubtract;
    public Text txtScore;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {

    }
    
    private static TestPanel _instance;
    public static TestPanel Instance => _instance;
}
