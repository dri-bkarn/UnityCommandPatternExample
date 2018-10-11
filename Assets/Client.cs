using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {

    private RemoteControl remoteControl;
    private LightController targetLight;

    [SerializeField] [ColorUsage(true)]
    private Color color;

    private void Start () {
        remoteControl = new RemoteControl();
        targetLight = GameObject.FindGameObjectWithTag("Light").GetComponent<LightController>();
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            remoteControl.SetCommand(new LightOnCommand(targetLight));
            remoteControl.CallCommand();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            remoteControl.SetCommand(new LightOffCommand(targetLight));
            remoteControl.CallCommand();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            remoteControl.SetCommand(new LightChangeColourCommand(targetLight, color));
            remoteControl.CallCommand();
            color = Random.ColorHSV();
        }
    }
}
