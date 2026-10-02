using UnityEngine;

public class SunRotation : MonoBehaviour
{
    public float rotationSpeed = 10f; // degrees per second

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }
}