using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Mediator;
using PureMVC.Interfaces;

public class Random_Mediator : Mediator
{
    public const string NAME = "Random_Mediator";

    public Random_Mediator(string mediatorName, object viewComponent = null) : base(mediatorName, viewComponent) { }

    private RandomPanel panel
    {
        get { return ViewComponent as RandomPanel; }
    }

    /// <summary>
    /// ��ע��֪ͨ�б�
    /// </summary>
    /// <returns></returns>
    public override string[] ListNotificationInterests()
    {
        return new string[]{
           
        };
    }

    /// <summary>
    /// ����֪ͨ����
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {

        }
    }

    public override void OnRegister()
    {
        base.OnRegister();
        // ��ӵ���¼�����
        panel.btnRandom.onClick.AddListener(OnRandomButtonClick);
    }

    private void OnRandomButtonClick()
    {
        SendNotification(NotificationConst.RANDOM_CLICK);
    }
}
