using UnityEngine;

public class IMUController : MonoBehaviour
{
    public float sensitivity = 50f;
    public float smoothing = 0.9f;
    private Vector3 smoothedAccel;

    void Update()
    {
        Vector3 rawAccel = Input.acceleration;
        smoothedAccel = Vector3.Lerp(smoothedAccel, rawAccel, 1 - smoothing);

        float pitch = Mathf.Clamp(smoothedAccel.y, -0.5f, 0.5f);
        float roll = Mathf.Clamp(smoothedAccel.x, -0.5f, 0.5f);

        transform.rotation = Quaternion.Euler(-pitch * sensitivity, 0f, -roll * sensitivity);
    }
}
