using UnityEngine;

public class healthpack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            other.GetComponent<HealtPoints>().Heal(1);
            Destroy(this.gameObject);
        }
    }
}
