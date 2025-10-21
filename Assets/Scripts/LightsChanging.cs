using UnityEngine;

public class LightsChanging : MonoBehaviour
{
    public Light Mylight;

    private float timer = 0f;
    public float changeInterval = 1f;

    private void OnTriggerStay(Collider other)
    {
        timer += Time.deltaTime;
        if (timer >= changeInterval)
        {
            Mylight.color = Random.ColorHSV(0f, 1f, 0.8f, 1f, 0.8f, 1f);
            timer = 0f;
        }
    }
}
