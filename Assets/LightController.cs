using UnityEngine;

public class LightController : MonoBehaviour {

    private Light l;

    private void Awake()
    {
        l = GetComponent<Light>();
    }
    public void LightOn()
    {
        l.enabled = true;
    }

    public void LightOff()
    {
        l.enabled = false;
    }
    public void LightChangeColour(Color color)
    {
        l.color = color;
    }

}
