using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    private Light flashlight;
    private bool isOn = true;

    void Start()
    {
        flashlight = GetComponent<Light>();
    }

    void Update()
    {
        // Fキーが押されたらライトの表示/非表示を切り替える
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            if (flashlight != null)
            {
                flashlight.enabled = isOn;
            }
        }
    }
}