using System.Collections;
using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns.Mediator;
using UnityEngine;
using UnityEngine.UI;

public class Test_Mediator : Mediator
{
    public const string NAME = "Test_Mediator";

    public Test_Mediator(string mediatorName, object viewComponent = null) : base(mediatorName, viewComponent) { }

    private TestPanel panel
    {
        get { return ViewComponent as TestPanel; }
    }

    /// <summary>
    /// 关注的通知列表
    /// </summary>
    /// <returns></returns>
    public override string[] ListNotificationInterests()
    {        
        return new string[]{
            NotificationConst.RANDOM_CLICK
        };
    }

    /// <summary>
    /// 接收通知处理
    /// </summary>
    /// <param name="notification"></param>
    public override void HandleNotification(INotification notification)
    {
        switch (notification.Name)
        {
            case NotificationConst.RANDOM_CLICK:
                UpdateScore(Random.Range(500, 1000));
                break;
        }
    }

    public override void OnRegister()
    {
        base.OnRegister();
        // 添加点击事件监听
        panel.btnAdd.onClick.AddListener(OnAddButtonClick);
        panel.btnSubtract.onClick.AddListener(OnSubtractButtonClick);
    }

    private void OnAddButtonClick()
    {
        int score = int.Parse(panel.txtScore.text);
        UpdateScore(++ score);
    }

    private void OnSubtractButtonClick()
    {
        int score = int.Parse(panel.txtScore.text);
        UpdateScore(-- score);
    }

    private void UpdateScore(int score)
    {
        panel.txtScore.text = score.ToString(); // 更新显示分数
    }
}
