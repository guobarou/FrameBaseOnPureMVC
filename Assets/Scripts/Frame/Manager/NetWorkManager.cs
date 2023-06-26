using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using PureMVC.Interfaces;
using PureMVC.Patterns.Observer;

public class NetWorkManager
{
    private static readonly ObserverManager ObserverManager = new ObserverManager();
    
    /// <summary>
    /// 批量注册消息
    /// </summary>
    /// <param name="msgLists">消息列表</param>
    /// <param name="notifyMethod"></param>
    /// <param name="notifyContext"></param>
    public static void RegisterMsgLists(List<int> msgLists, Action<INotification> notifyMethod, object notifyContext)
    {
        foreach (var key in msgLists)
        {
            var observer = new Observer(notifyMethod, notifyContext);
            ObserverManager.RegisterObserver(key, observer);
        }
    }

    /// <summary>
    /// 批量移除消息
    /// </summary>
    /// <param name="msgLists"></param>
    /// <param name="notifyContext"></param>
    public static void RemoveMsgLists(List<int> msgLists, object notifyContext)
    {
        foreach (var key in msgLists)
        {
            ObserverManager.RemoveObserver(key, notifyContext);
        }
    }
}
