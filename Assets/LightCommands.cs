using UnityEngine;

public class LightOnCommand : ICommand
{
    LightController l;
    public LightOnCommand(LightController l)
    {
        this.l = l;
    }

    public void Execute()
    {
        l.LightOn();
    }
}

public class LightOffCommand : ICommand
{
    LightController l;
    public LightOffCommand(LightController l)
    {
        this.l = l;
    }

    public void Execute()
    {
        l.LightOff();
    }
}

public class LightChangeColourCommand : ICommand
{
    LightController l;
    Color color;

    public LightChangeColourCommand(LightController l, Color color )
    {
        this.l = l;
        this.color = color;
    }

    public void Execute()
    {
        l.LightChangeColour(color);
    }
}
