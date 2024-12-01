using UnityEngine;

public class WierdMover : MonoBehaviour 
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] int velocity = 3;
    [SerializeField] int width = 5;

    private void Update()
    {
        // Move the object in a snake-like pattern down the screen
        transform.position += (Vector3.down * velocity + Vector3.right * width * Mathf.Sin(Time.time)) * Time.deltaTime;

    }
}
