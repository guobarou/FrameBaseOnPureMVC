using System;
using System.Collections;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns.Facade;
using UnityEngine;

public class Test_Facade : Facade
{

    protected override void InitializeController() {
        base.InitializeController();
        RegisterCommand(Test_Command.NAME, () => new Test_Command());
    } 

}
