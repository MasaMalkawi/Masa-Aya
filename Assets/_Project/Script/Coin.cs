using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 100f; // سرعة الدوران

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
