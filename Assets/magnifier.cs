// using UnityEngine;

// public class magnifier : MonoBehaviour
// {
//     private float x;
//     void Update()
//     {
//         x = 0.2f*Mathf.Sin(3*Time.time);
//         transform.localScale = new Vector3(x, x, 1);
//         if (x == 0){
//             Destroy(this.gameObject);
//         }
//     }
// }

using UnityEngine;

public class Magnifier : MonoBehaviour
{
    private float timeElapsed = 0f;
    private float cycleDuration;

    void Start()
    {
        // Calculate the duration of one full cycle of the sine wave (T = 2π / ω)
        cycleDuration = Mathf.PI / 6f; // 3 is the frequency multiplier in your sine function
    }

    void Update()
    {
        // Update time elapsed
        timeElapsed += Time.deltaTime;

        // Calculate the scale based on the sine wave
        float x = 0.2f * Mathf.Sin(6 * timeElapsed);
        transform.localScale = new Vector3(x, x, 1);

        // Destroy the object after one cycle
        if (timeElapsed >= cycleDuration)
        {
            Destroy(this.gameObject);
        }
    }
}
