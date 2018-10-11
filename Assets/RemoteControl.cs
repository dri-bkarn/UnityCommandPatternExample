using UnityEngine;

public class RemoteControl : MonoBehaviour
{
    ICommand command;

    public RemoteControl()
    {
        this.command = new NoCommand();
    }

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void CallCommand()
    {
        command.Execute();
    }

}

public class NoCommand : ICommand
{
    public void Execute() { }
}