
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

public class Test_Command : SimpleCommand
{
    public const string NAME = "Test_Command";

    public override void Execute(INotification notification)
    {
        StartUp();
    }

    private void StartUp()
    {
        Facade.RegisterMediator(new Test_Mediator(Test_Mediator.NAME, TestPanel.Instance));
        Facade.RegisterProxy(new Test_ReceiveProxy(Test_ReceiveProxy.NAME));
        Facade.RegisterProxy(new Test_SendProxy(Test_SendProxy.NAME));

        Facade.RegisterMediator(new Random_Mediator(Random_Mediator.NAME, RandomPanel.Instance));
    }

    private void ShutDown()
    {

    }
}