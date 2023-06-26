using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns.Proxy;
using UnityEngine;

public class Test_ReceiveProxy : Proxy
{
    public const string NAME = "Test_ReceiveProxy";

    private readonly List<int> _msgLists = new List<int>()
    {
        10000
    };

    public Test_ReceiveProxy(string proxyName, object data = null) : base(proxyName, data) {}

    private Test_Mediator _testMediator;
    private Test_Mediator  TestMediator
    {
        get { return _testMediator ?? Facade.RetrieveMediator(Test_Mediator.NAME) as Test_Mediator; }
    }

    public override void OnRegister()
    {
        Debug.Log("注册了：Test_ReceiveProxy");
        NetWorkManager.RegisterMsgLists(_msgLists, ReceivedMsgHandle, NAME);
    }

    public override void OnRemove()
    {
        Debug.Log("注销了：Test_ReceiveProxy");
        NetWorkManager.RemoveMsgLists(_msgLists, NAME);
    }
    
   private void ReceivedMsgHandle(INotification notification)
    {
        var name = notification.Name;
        // var data = notification.Body as ByteArray;
        // if(this.hasOwnProperty("received_"+name))
        // {
        //     this["received_"+name](data);
        // }
        // else
        // {
        //     ZLog.add("协议号"+name+"不存在");
        // }
    }
   
   public void received_78622(object data)
   {
       var mode = data;
       // TestMediator.OnRegister();
   }
       
}
