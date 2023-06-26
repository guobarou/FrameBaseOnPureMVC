using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPanel : MonoBehaviour
{
    public Button btnRandom;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {

    }

    private static RandomPanel _instance;
    public static RandomPanel Instance => _instance;
}
