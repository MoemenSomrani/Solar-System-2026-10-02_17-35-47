using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform sun;
    public float orbitSpeed = 30f;
    public float rotationSpeed = 50f;

    void Update()
    {
        if (sun == null) return;
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }
}