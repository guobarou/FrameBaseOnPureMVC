using System;
using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns.Facade;
using UnityEngine;

public class Main : MonoBehaviour
{

    private void Awake()
    {
        Test_Facade testFacade =  Facade.GetInstance(() => new Test_Facade()) as Test_Facade;
        testFacade.SendNotification(Test_Command.NAME);
    }
}
