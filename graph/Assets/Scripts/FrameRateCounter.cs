using UnityEngine;
using TMPro;

public class FrameRateCounter : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI display;

    int frames;

    float duration;

    void Update()
    {
        float frameDuration = Time.unscaledDeltaTime;
        frames += 1;
        duration += frameDuration;
        display.SetText("FPS\n{0:0}\n000\n000", 1f / frameDuration, frames / duration);
    }
}
