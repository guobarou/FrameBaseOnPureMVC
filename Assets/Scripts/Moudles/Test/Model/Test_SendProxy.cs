using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns.Proxy;
using UnityEngine;

public class Test_SendProxy : Proxy
{
    public const string NAME = "Test_SendProxy";
    
    public Test_SendProxy(string proxyName, object data = null) : base(proxyName, data)
    {
        Debug.Log("注册了：Test_SendProxy");
    }
}
